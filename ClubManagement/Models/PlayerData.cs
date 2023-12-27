using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Models
{
   public class PlayerData
    {
        public PlayerData(int id, string firstName, string lastName, DateTime dateOfBirth, string phone, string email, string country, string city, string postalCode, string street, int houseNumber, int flatNumber, string nick, int positionId, int number, string leg, byte[] photo = null)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            Email = email;
            Country = country;
            City = city;
            PostalCode = postalCode;
            Street = street;
            HouseNumber = houseNumber;
            FlatNumber = flatNumber;
            Nick = nick;
            PositionId = positionId;
            Number = number;
            Leg = leg;
            Photo = photo;
        }

        public PlayerData()
        {
            
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int FlatNumber { get; set; }
        public string Nick { get; set; }
        public int PositionId { get; set; }
        public int Number { get; set; }
        public string Leg { get; set; }

        public byte[] Photo { get; set; }



    }
}
