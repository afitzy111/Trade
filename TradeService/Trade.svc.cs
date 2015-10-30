using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DataAccessLayer;
namespace TradeService
{
   
    [DataContract]
    public class Trade : ITrade
    {
#region Address       
        AddressClass db = new AddressClass();
        [DataMember]
        public Address Address
        {
            get { return Address; }
            set { Address = value; }
        }

        //Get all Addresses method
        public List<Address> GetAllAddresses()
        {
            return db.GetAddresses();
        }
        //Create address
        public void CreateAddress(Address address)
        {
            db.CreateAddress(address);
        }
        //Delete address
        public void DeleteAddress(int id)
        {
            db.DeleteAddress(id);
        }
        //Update address
        public void UpdateAddress(int id, Address address)
        {
            db.UpdateAddress(id, address);
        }
        //Get a single address
        public Address GetSingleAddress(int id)
        {
            return db.GetSingleAddress(id);
        }
        #endregion
#region Legal Entities       
        LegalEntityClass ledb = new LegalEntityClass();
        [DataMember]
        public LegalEntity LegalEntity
        {
            get { return LegalEntity; }
            set { LegalEntity = value; }
        }

        //Get all Legal Entities method
        public List<LegalEntity> GetAllLegalEntities()
        {
            return ledb.GetLegalEntities();
        }

        //Create new legal entity
        public void CreateLegalEntities(LegalEntity legalEntity)
        {
            ledb.CreateLegalEntity(legalEntity);
        }

        //Delete Legal Entity
        public void DeleteLegalEntities(int id)
        {
            ledb.DeleteLegalEntity(id);
        }

        //Update legal entity
        public void UpdateLegalEntities(int id, LegalEntity legalEntity)
        {
            ledb.UpdateLegalEntity(id, legalEntity);
        }

        //Retrieve single legal entity
        public LegalEntity GetSingleLegalEntity(int id)
        {
            return ledb.GetSingleLegalEntity(id);
        }
        #endregion
    }
}