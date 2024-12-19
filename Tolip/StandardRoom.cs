using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolip
{
    public abstract class Room
    {
        public string RoomType { get; protected set; }
        public string PhoneNumber { get; protected set; }
        public string Free { get; protected set; }

        protected Room(string roomType, string phoneNumber, string free)
        {
            RoomType = roomType;
            PhoneNumber = phoneNumber;
            Free = free;
        }

        public abstract void ShowDetails();
    }

    public class StandardRoom : Room
    {
        public StandardRoom(string phoneNumber, string free)
            : base("Standard", phoneNumber, free) { }

        public override void ShowDetails()
        {
            Console.WriteLine($"Standard Room - Phone: {PhoneNumber}, Free: {Free}");
        }
    }

    public class DeluxeRoom : Room
    {
        public DeluxeRoom(string phoneNumber, string free)
            : base("Deluxe", phoneNumber, free) { }

        public override void ShowDetails()
        {
            Console.WriteLine($"Deluxe Room - Phone: {PhoneNumber}, Free: {Free}");
        }
    }
    public static class RoomFactory
    {
        public static Room CreateRoom(string roomType, string phoneNumber, string free)
        {
            switch (roomType)
            {
                case "Single":
                    return new StandardRoom(phoneNumber, free);
                case "Double":
                    return new DeluxeRoom(phoneNumber, free);
                case "Family":
                    return new DeluxeRoom(phoneNumber, free);
                case "Suite":
                    return new DeluxeRoom(phoneNumber, free);
                default:
                    throw new ArgumentException("Invalid room type");
            }
        }

    }

}
