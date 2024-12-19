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

    public class SingleRoom : Room
    {
        public SingleRoom(string phoneNumber, string free)
            : base("Single", phoneNumber, free) { }

        public override void ShowDetails()
        {
            Console.WriteLine($"Single Room - Phone: {PhoneNumber}, Free: {Free}");
        }
    }

    public class DoubleRoom : Room
    {
        public DoubleRoom(string phoneNumber, string free)
            : base("Double", phoneNumber, free) { }

        public override void ShowDetails()
        {
            Console.WriteLine($"Double Room - Phone: {PhoneNumber}, Free: {Free}");
        }
    }

    public class FamilyRoom : Room
    {
        public FamilyRoom(string phoneNumber, string free)
            : base("Family", phoneNumber, free) { }

        public override void ShowDetails()
        {
            Console.WriteLine($"Family Room - Phone: {PhoneNumber}, Free: {Free}");
        }
    }


    public class SuiteRoom : Room
    {
        public SuiteRoom(string phoneNumber, string free)
            : base("Suite", phoneNumber, free) { }

        public override void ShowDetails()
        {
            Console.WriteLine($"Suite Room - Phone: {PhoneNumber}, Free: {Free}");
        }
    }
    public static class RoomFactory
    {
        public static Room CreateRoom(string roomType, string phoneNumber, string free)
        {
            switch (roomType)
            {
                case "Single":
                    return new SingleRoom(phoneNumber, free);
                case "Double":
                    return new DoubleRoom(phoneNumber, free);
                case "Family":
                    return new FamilyRoom(phoneNumber, free);
                case "Suite":
                    return new SuiteRoom(phoneNumber, free);
                default:
                    throw new ArgumentException("Invalid room type");
            }
        }

    }

}
