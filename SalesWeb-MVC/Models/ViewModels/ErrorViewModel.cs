using System;

namespace SalesWeb_MVC.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Mensagem { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    }
}