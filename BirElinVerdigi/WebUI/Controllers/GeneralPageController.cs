using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebUI.Filters;
using WebUI.Models;
using WebUI.wwwroot.Atributes;

namespace WebUI.Controllers
{
    [ServiceFilter(typeof(LoginFilter))]
    public class GeneralPageController : Controller
    {


        private ITbl_MemberService _MemberService;
        private ITbl_AdService _AdService;
        private IView_AdInfoService _AdInfoService;
        private IView_MessageService _MessageService;
        private ITbl_MessageService _tbl_MessageService;
        private ITbl_RequestService _RequestService;

        public GeneralPageController(ITbl_MemberService tbl_MemberService, ITbl_RequestService tbl_RequestService, ITbl_AdService tbl_AdService, ITbl_MessageService Tbl_MessageService, IView_AdInfoService View_AdInfoService, IView_MessageService View_MessageService)
        {
            _RequestService = tbl_RequestService;
            _MemberService = tbl_MemberService;
            _AdService = tbl_AdService;
            _AdInfoService = View_AdInfoService;
            _MessageService = View_MessageService;
            _tbl_MessageService = Tbl_MessageService;
        }

        [Ignore]
        [Route("")]
        public ActionResult Index()
        {
            TempData["isLoggedIn"] = HttpContext.Session.GetString("token");
            TempData["memberID"] = HttpContext.Session.GetString("memberID");

            return View();
        }
        [Ignore]
        [HttpPost]
        public ActionResult SignInUser(Tbl_Member user)
        {
            Tbl_Member loginData = _MemberService.LoginControlGet(user.IDNumber, user.MemberPassword);
            if (loginData != null)
            {
                string token = Guid.NewGuid().ToString() + "æ" + DateTime.Now + "-" + loginData.MemberID;
                string memberID = loginData.MemberID.ToString();
                HttpContext.Session.Set("token", System.Text.Encoding.UTF8.GetBytes(token));
                HttpContext.Session.Set("memberID", System.Text.Encoding.UTF8.GetBytes(memberID));
                HttpContext.Session.SetString("userID", loginData.MemberID.ToString());
                ViewBag.Token = token;
                TempData["isLoggedIn"] = token.ToString();
                TempData["memberID"] = memberID.ToString();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", "GeneralPage");
            }
        }
        [Ignore]
        [HttpPost]
        public ActionResult MemberRecord(Tbl_Member model)
        {
            _MemberService.Add(model);
            return RedirectToAction("Index");

            //   return RedirectToAction("MemberLogin", "GeneralPage");
        }
        [Ignore]
        [HttpPost]
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }
        [Ignore]
        [Route("Hakkimizda")]
        public ActionResult About()
        {
            return View();
        }

        [Ignore]
        [Route("Mesajlar")]
        public ActionResult Message(int id)
        {
            var session = HttpContext.Session;
            if (session != null)
            {
                HttpContext.Session.TryGetValue("token", out var result);
                if (result != null)
                {
                    TempData["memberID"] = HttpContext.Session.GetString("memberID");
                    int memberID = Convert.ToInt32(TempData["memberID"].ToString());

                    MessageDetailViewModel model = new MessageDetailViewModel();
                    model.allMessages = _MessageService.GetAll().Where(x => x.MemberID == memberID).ToList();
                    model.allMessages = _MessageService.GetAll().Where(x => x.MemberID == memberID || x.RequestMemberID == memberID).OrderBy(x => x.RequestID).OrderByDescending(x => x.MessageDate).ToList();
                    if (model.allMessages != null && model.allMessages.Count != 0)
                    {
                        if (id == 0)
                            model.messages = _tbl_MessageService.GetAll().Where(x => x.MessageRequestID == model.allMessages[0].MessageRequestID).ToList();
                        else
                            model.messages = _tbl_MessageService.GetAll().Where(x => x.MessageRequestID == id).ToList();
                    }
                    model.memberID = memberID;

                    return View(model);
                }
            }
            return RedirectToAction("Index", "GeneralPage");
        }

        [Ignore]
        public ActionResult MessageSend(MessageDetailViewModel model)
        {
            var session = HttpContext.Session;
            if (session != null)
            {
                HttpContext.Session.TryGetValue("token", out var result);
                if (result != null)
                {
                    TempData["memberID"] = HttpContext.Session.GetString("memberID");
                    int memberID = Convert.ToInt32(TempData["memberID"].ToString());

                    Tbl_Message message = model.messageSend;
                    message.SenderMemberID = memberID;
                    message.MessageDate = DateTime.Now;
                    _tbl_MessageService.Add(message);
                    return RedirectToAction("Message", "GeneralPage", new { id = message.MessageRequestID });
                }
            }
            return RedirectToAction("Index", "GeneralPage");
        }
        [Ignore]
        public ActionResult MessageDelete(int id)
        {
            var session = HttpContext.Session;
            if (session != null)
            {
                HttpContext.Session.TryGetValue("token", out var result);
                if (result != null)
                {
                    TempData["memberID"] = HttpContext.Session.GetString("memberID");
                    int memberID = Convert.ToInt32(TempData["memberID"].ToString());

                    Tbl_Message message = _tbl_MessageService.Get(id);
                    _tbl_MessageService.Delete(message);
                    return RedirectToAction("Message", "GeneralPage", new { id = message.MessageRequestID });
                }
            }
            return RedirectToAction("Index", "GeneralPage");
        }
        [Ignore]
        [HttpGet]
        public ActionResult RequestNewAdMessage(int id)
        {
            var session = HttpContext.Session;
            if (session != null)
            {
                HttpContext.Session.TryGetValue("token", out var result);
                if (result != null)
                {
                    TempData["isLoggedIn"] = HttpContext.Session.GetString("token");
                    TempData["memberID"] = HttpContext.Session.GetString("memberID");
                    int memberID = Convert.ToInt32(TempData["memberID"].ToString());
                    Tbl_Ad ad = _AdService.Get(id);
                    Tbl_Request Request = _RequestService.GetAll().Where(x => x.AdID == id && x.RequestMemberID == memberID).LastOrDefault();
                    Tbl_Message lastMessage = new Tbl_Message();
                    if (Request == null && ad.MemberID != memberID)
                    {
                        Tbl_Request newRequest = new Tbl_Request()
                        {
                            AdID = id,
                            RequestMemberID = memberID,
                            RequestStateID = 1
                        };
                        _RequestService.Add(newRequest);

                       
                    }
                    Tbl_Request lastRequest = _RequestService.GetAll().LastOrDefault();
                    Tbl_Message message = new Tbl_Message
                    {
                        SenderMemberID = memberID,
                        Message = "Konu Başlığı: " + ad.AdTitle,
                        MessageDate = DateTime.Now,
                        MessageRequestID = lastRequest.RequestID,
                    };
                    _tbl_MessageService.Add(message);
                    lastMessage = _tbl_MessageService.GetAll().LastOrDefault();

                    return RedirectToAction("Message", "GeneralPage", new { id = lastMessage.MessageRequestID });
                }
            }
            return RedirectToAction("Index", "GeneralPage");
        }
        [Ignore]
        [HttpGet]
        public ActionResult MemberRequestMessage(int id)
        {
            var session = HttpContext.Session;
            if (session != null)
            {
                HttpContext.Session.TryGetValue("token", out var result);
                if (result != null)
                {
                    TempData["isLoggedIn"] = HttpContext.Session.GetString("token");
                    TempData["memberID"] = HttpContext.Session.GetString("memberID");
                    int memberID = Convert.ToInt32(TempData["memberID"].ToString());
                    Tbl_Ad ad = _AdService.Get(id);
                    Tbl_Request Request = _RequestService.GetAll().Where(x => x.AdID == id && x.RequestMemberID == memberID).LastOrDefault();
                    Tbl_Message messagednm = _tbl_MessageService.GetAll().Where(x => x.MessageRequestID == Request.RequestID).LastOrDefault();
                    Tbl_Message lastMessage = new Tbl_Message();
                    if (messagednm == null)
                    {
                        Tbl_Request newRequest = new Tbl_Request()
                        {
                            AdID = id,
                            RequestMemberID = memberID,
                            RequestStateID = 1
                        };
                        _RequestService.Add(newRequest);

                        Tbl_Request lastRequest = _RequestService.GetAll().LastOrDefault();
                        Tbl_Message message = new Tbl_Message
                        {
                            SenderMemberID = memberID,
                            Message = "Konu Başlığı: " + ad.AdTitle,
                            MessageDate = DateTime.Now,
                            MessageRequestID = lastRequest.RequestID,
                        };
                        _tbl_MessageService.Add(message);
                        lastMessage = _tbl_MessageService.GetAll().LastOrDefault();
                    }
                    else
                        lastMessage = _tbl_MessageService.GetAll().Where(x => x.MessageRequestID == Request.RequestID).LastOrDefault();

                    return RedirectToAction("Message", "GeneralPage", new { id = lastMessage.MessageRequestID });
                }
            }
            return RedirectToAction("Index", "GeneralPage");
        }

        [Ignore]
        [Route("Contact")]
        [HttpGet]
        public ActionResult Contact()
        {
            Form yeni = new Form();
            return View(yeni);
        }
        [HttpPost]
        [Ignore]
        public ActionResult IletisimPosta(Form eposta)
        {
            try
            {
                string nameSurname = eposta.Name;
                string mail = eposta.Email;
                string message = eposta.Message;
                string subject = eposta.Subject;

                var from = new MailAddress("aynur@megyazilim.com.tr");
                var toAddres = new MailAddress("fatoseraslan275@gmail.com");
                string content = "Name: " + nameSurname;
                content += "<br>Email: " + mail;
                content += "<br>Subject: " + subject;
                content += "<br>Mesaj: " + message;
                using (var smpt = new SmtpClient
                {
                    Host = "smtp.yandex.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential("aynur@megyazilim.com.tr", "Aynur20")
                })
                {
                    using (var mesaj = new MailMessage(from, toAddres) { Subject = subject, Body = content })
                    {
                        mesaj.IsBodyHtml = true;
                        smpt.Send(mesaj);
                    }
                }
            }
            catch
            {
            }
            return RedirectToAction("Contact", "GeneralPage");
        }
        [HttpPost]
        [Ignore]
        public ActionResult sendPassword(Tbl_Member member)
        {
            Tbl_Member memberInfo = _MemberService.GetAll().Where(x => x.MemberMail == member.MemberMail).LastOrDefault();
            try
            {
                string nameSurname = memberInfo.MemberName;
                string mail = memberInfo.MemberMail;
                string message = "Şifreniz: " + memberInfo.MemberPassword;
                string subject = "Şifremi Unuttum";

                var from = new MailAddress("aynur@megyazilim.com.tr");
                var toAddres = new MailAddress(memberInfo.MemberMail);
                string content = "AD: " + nameSurname;
                content += "<br>MAİL: " + mail;
                content += "<br>KONU: " + subject;
                content += "<br>Mesaj: " + message;
                using (var smpt = new SmtpClient
                {
                    Host = "smtp.yandex.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential("aynur@megyazilim.com.tr", "Aynur20")
                })
                {
                    using (var mesaj = new MailMessage(from, toAddres) { Subject = subject, Body = content })
                    {
                        mesaj.IsBodyHtml = true;
                        smpt.Send(mesaj);
                    }
                }
            }
            catch
            {
            }
            return RedirectToAction("Contact", "GeneralPage");
        }
        [Ignore]
        [Route("Ilanlar")]
        public ActionResult Ad(int id)
        {
            var session = HttpContext.Session;
            if (session != null)
            {
                HttpContext.Session.TryGetValue("token", out var result);
                if (result != null)
                {
                    TempData["isLoggedIn"] = HttpContext.Session.GetString("token");
                    TempData["memberID"] = HttpContext.Session.GetString("memberID");
                    List<View_AdInfo> Ads = new List<View_AdInfo>();
                    if (id == 0)
                        Ads = _AdInfoService.GetAll();
                    else
                        Ads = _AdInfoService.GetAll().Where(x => x.CityID == id).ToList();

                    return View(Ads);
                }
            }
            return RedirectToAction("Index", "GeneralPage");
        }
    }
}
