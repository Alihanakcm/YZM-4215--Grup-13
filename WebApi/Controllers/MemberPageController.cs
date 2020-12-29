using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{

    public class MemberPageController : Controller
    {
        private ITbl_MemberService _MemberService;
        private ITbl_CityService _CityService;
        private ITbl_AdService _AdService;
        private ITbl_CategoryService _CategoryService;
        private ITbl_RequestService _RequestService;
        private IView_AdGeneralInfoService _AdGeneralInfoService;

        public MemberPageController(ITbl_RequestService tbl_RequestService, ITbl_CityService tbl_CityService, ITbl_MemberService tbl_MemberService, ITbl_AdService tbl_AdService, ITbl_CategoryService tbl_CategoryService, IView_AdGeneralInfoService View_AdGeneralInfoService)
        {
            _RequestService = tbl_RequestService;
            _CategoryService = tbl_CategoryService;
            _MemberService = tbl_MemberService;
            _CityService = tbl_CityService;
            _AdService = tbl_AdService;
            _AdGeneralInfoService = View_AdGeneralInfoService;
        }
        
        [Route("MemberAdListCrud")]
        public JsonResult MemberAdListCrud()
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
                    AdViewModel model = new AdViewModel();
                    model.ads = _AdService.GetAll().Where(x => x.MemberID == memberID).ToList();
                    model.allCity = _CityService.GetAll();
                    model.allCategories = _CategoryService.GetAll();
                    return Json(model);
                }
            }
           return Json("Giriş Yapın");
        }
        
        [HttpPost]
        public JsonResult MemberNewAd(AdViewModel model)
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
                    Tbl_Ad ad = model.ad;
                    ad.MemberID = memberID;
                    ad.AdState = "akrif";
                    _AdService.Add(ad);
                    return Json(Ok());
                    //return Json("MemberAdListCrud", "MemberPage");
                }
            }
           return Json("Giriş Yapın");
        }
        
        [HttpPost]
        public JsonResult MemberAdUpdate(AdViewModel model)
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
                    Tbl_Ad ad = model.ad;
                    ad.AdState = "akrif";
                    _AdService.Update(ad);
                    return Json(Ok());
                   // return Json("MemberAdListCrud", "MemberPage");
                }
            }
           return Json("Giriş Yapın");
        }
        
        [HttpGet]
        public JsonResult MemberAdDelete(int id)
        {
            var session = HttpContext.Session;
            if (session != null)
            {
                HttpContext.Session.TryGetValue("token", out var result);
                if (result != null)
                {
                    TempData["isLoggedIn"] = HttpContext.Session.GetString("token");
                    TempData["memberID"] = HttpContext.Session.GetString("memberID");
                    Tbl_Ad ad = _AdService.Get(id);
                    _AdService.Delete(ad);
                    return Json(Ok());
                    //return Json("MemberAdListCrud", "MemberPage");
                }
            }
           return Json("Giriş Yapın");
        }
        
        [Route("MemberRequestListCrud")]
        public JsonResult MemberRequestListCrud()
        {
            var session = HttpContext.Session;
            if (session != null)
            {
                HttpContext.Session.TryGetValue("token", out var result);
                if (result != null)
                {
                    TempData["isLoggedIn"] = HttpContext.Session.GetString("token");
                    TempData["memberID"] = HttpContext.Session.GetString("memberID");
                    AdViewModel model = new AdViewModel();
                    model.MemberID = Convert.ToInt32(TempData["memberID"].ToString());
                    model.AdInfo = _AdGeneralInfoService.GetAll();
                    return Json(model);
                }
            }
           return Json("Giriş Yapın");
        }
        
        [HttpGet]
        public JsonResult RequestNewAd(int id)
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
                    return Json(Ok());
                   // return Json("MemberRequestListCrud", "MemberPage");
                }
            }
           return Json("Giriş Yapın");
        }




        
        [HttpGet]
        public JsonResult MemberRequestCancel(int id)
        {
            var session = HttpContext.Session;
            if (session != null)
            {
                HttpContext.Session.TryGetValue("token", out var result);
                if (result != null)
                {
                    TempData["isLoggedIn"] = HttpContext.Session.GetString("token");
                    TempData["memberID"] = HttpContext.Session.GetString("memberID");
                    Tbl_Request request = _RequestService.Get(id);
                    _RequestService.Delete(request);

                    return Json(Ok());
                   // return Json("MemberRequestListCrud", "MemberPage");
                }
            }
           return Json("Giriş Yapın");
        }


        
        [HttpGet]
        public JsonResult MemberRequestAccept(int id)
        {
            var session = HttpContext.Session;
            if (session != null)
            {
                HttpContext.Session.TryGetValue("token", out var result);
                if (result != null)
                {
                    TempData["isLoggedIn"] = HttpContext.Session.GetString("token");
                    TempData["memberID"] = HttpContext.Session.GetString("memberID");
                    Tbl_Request request = _RequestService.Get(id);
                    request.RequestStateID = 2;
                    _RequestService.Update(request);
                    return Json(Ok());
                   // return Json("MemberRequestListCrud", "MemberPage");
                }
            }
           return Json("Giriş Yapın");
        }


        
        [HttpGet]
        public JsonResult MemberRequestReject(int id)
        {
            var session = HttpContext.Session;
            if (session != null)
            {
                HttpContext.Session.TryGetValue("token", out var result);
                if (result != null)
                {
                    TempData["isLoggedIn"] = HttpContext.Session.GetString("token");
                    TempData["memberID"] = HttpContext.Session.GetString("memberID");
                    Tbl_Request request = _RequestService.Get(id);
                    request.RequestStateID = 3;
                    _RequestService.Update(request);
                    return Json(Ok());
                   // return Json("MemberRequestListCrud", "MemberPage");
                }
            }
           return Json("Giriş Yapın");
        }




    }
}
