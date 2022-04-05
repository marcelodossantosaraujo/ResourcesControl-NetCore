using System;

namespace APIResources.Models
{
    /// Base for usiling on all objects for maintain control
    public class Base
    {
        ///Id of the person responsible for the registration
        public int IdRespRegistration {get;set;}
        ///Id of the person responsible for the change
        public int IdRespChange {get;set;}
        public DateTime DateRegister {get;set;}
        public DateTime? DateChange {get;set;}

    }
}