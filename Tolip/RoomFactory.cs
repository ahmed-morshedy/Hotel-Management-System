//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tolip
//{
//    public static class RoomFactory
//    {
//        public static Room CreateRoom(string roomType, string phoneNumber, string free)
//        {
//            return roomType switch
//            {
//                "Standard" => new StandardRoom(phoneNumber, free),
//                "Deluxe" => new DeluxeRoom(phoneNumber, free),
//                _ => throw new ArgumentException("Invalid room type"),
//            };
//        }
//    }

//}
