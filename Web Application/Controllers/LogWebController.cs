﻿using Web_Application.DAO;
using Web_Application.Models;

namespace Web_Application.Controllers
{
    public class LogWebController : GenericController<LogWebViewModel>
    {
        protected override void SetDAO() => DAO = new LogWebDAO();
    }
}