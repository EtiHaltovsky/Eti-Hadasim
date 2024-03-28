//using BL;
//using DTO;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using System.Web.Http.Cors;


//namespace API.Controllers
//{
//    [EnableCors("*", "*", "*")]
//    [RoutePrefix("api/address")]
//    public class AddressController : ApiController
//    {

//        //Function to add an address
//        [Route("GetAddNewAddress/{Id}/{City}/{Street}/{Number}")]
//        public int GetAddNewAddress( int id, string city, string Street,int Number)

//        {
//            return AddressBL.AddNewAddress(new Address(id, city, Street,Number));
//        }
//        // A function to update an address
//        [Route("GetUpdateAddress/{id}/{city}/{Street}/{Number}")]
//        public bool GetUpdateAddress(int id, string city, string Street, int Number)
//        {
//            return AddressBL.UpdateAddress(new Address(id, city, Street, Number));

//        }
//        //A function for retrieving an address by id
//        [Route("GetAddress/{Id}")]
//        public Address GetAddress(int id)
//        {
//            return AddressBL.GetAddressById(id);
//        }

//        // Function to delete an address
//        [Route("GetDelete/{Id}")]
//        public int GetDelete(int id)
//        {
//            return AddressBL.GetDeleteAddress(id);
//        }

//        //A function to retrieve all addresses
//        [Route("GetAllAddresses")]
//        public List<Address> GetAllAddresses()
//        {
//            //Transfer to the handler
//            List<Address> Addresses = AddressBL.GetAddresses();
//            //Returning the answer to the user
//            return Addresses;
//        }

//    }
//}
