﻿using APIConcepts.Services;
using APIConcepts.Services.TransientScopedSingleton;

using Microsoft.AspNetCore.Mvc;

namespace APIConcepts.Controllers
{
    public class Home1Controller :Controller
    {
        //private readonly IMessageService _messageService; 
        //public HomeController(IMessageService messageService) { 
        //    _messageService = messageService; }
        ////public string Index() { 
        ////    return _messageService.GetMessage(); 
        ////}
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly ILogger<Home1Controller> _logger;
        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;
        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;

        public Home1Controller(ILogger<Home1Controller> logger,
            ITransientService transientService1,
            ITransientService transientService2,
            IScopedService scopedService1,
            IScopedService scopedService2,
            ISingletonService singletonService1,
            ISingletonService singletonService2)
        {
            _logger = logger;
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }
        public IActionResult Index()
        {
            ViewBag.transient1 = _transientService1.GetOperationID().ToString();
            ViewBag.transient2 = _transientService2.GetOperationID().ToString();
            ViewBag.scoped1 = _scopedService1.GetOperationID().ToString();
            ViewBag.scoped2 = _scopedService2.GetOperationID().ToString();
            ViewBag.singleton1 = _singletonService1.GetOperationID().ToString();
            ViewBag.singleton2 = _singletonService2.GetOperationID().ToString();
            return View();
        }
    }
}
