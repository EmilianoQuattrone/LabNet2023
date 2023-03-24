using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class UsuariosView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public AddressView Address { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
    }
    public class AddressView
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public GeoView Geo { get; set; }
    }
    public class GeoView
    {
        public string Lat { get; set; }
        public string Lng { get; set; }
    }
}