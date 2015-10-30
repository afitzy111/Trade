using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AddressClass
    {
        //Retrieve all addresses method
        public List<Address> GetAddresses()
        {
            using (TradingDatabaseEntities context = new TradingDatabaseEntities())
            {
                List<Address> allAddresses = new List<Address>();
                foreach (Address a in context.Addresses)
                {
                    allAddresses.Add(a);
                }
                return allAddresses;
            }
        }

        //Method to create a new address
        public void CreateAddress(Address address)
        {
            using (TradingDatabaseEntities context = new TradingDatabaseEntities())
            {
                if (address == null)
                {
                    context.Addresses.Add(address);
                    context.SaveChanges();
                }
            }
        }

        //Method to update an existing address
        public void UpdateAddress(int id, Address newAddress)
        {
            using (TradingDatabaseEntities context = new TradingDatabaseEntities())
            {
                Address addressToUpdate = (from a in context.Addresses
                                           where a.ID == id
                                           select a).FirstOrDefault();
                if (newAddress != null)
                {
                    addressToUpdate.Line_1 = newAddress.Line_1;
                    addressToUpdate.Line_2 = newAddress.Line_2;
                    addressToUpdate.Line_3 = newAddress.Line_3;
                    addressToUpdate.City = newAddress.City;
                    addressToUpdate.Country = newAddress.Country;
                    addressToUpdate.Postcode = newAddress.Postcode;

                    context.SaveChanges();
                }
            }
        }

        //Method to delete an address
        public void DeleteAddress(int id)
        {
            using (TradingDatabaseEntities context = new TradingDatabaseEntities())
            {
                Address addressToDelete = (from a in context.Addresses
                                           where a.ID == id
                                           select a).FirstOrDefault();
                if (addressToDelete != null)
                {
                    context.Addresses.Remove(addressToDelete);
                    context.SaveChanges();
                }
            }
        }

        //Method to retrieve a single address
        public Address GetSingleAddress(int id)
        {
            using (TradingDatabaseEntities context = new TradingDatabaseEntities())
            {
                /* Address addressToFind = (from a in context.Addresses
                                          where a.ID == id
                                          select a).FirstOrDefault();*/
               Address addressToFind = context.Addresses.First(a => a.ID == id);

                return addressToFind;
            }
            
        }
    }
}

