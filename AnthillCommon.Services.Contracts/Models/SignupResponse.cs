using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services.Contracts.Models
{
    //osipenkom: класс с одним полем, в чем его суть? 
    public class SignupResponse
    {
        //osipenkom: в поле лежит единичный объект, а по неймингу кажется, что объектов может быть множество
        public AccessTokenResult TokenResults { get; set; }
    }
}
