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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITrade
    {
        //Address 
        [OperationContract]
        List<Address> GetAllAddresses();

        [OperationContract]
        void CreateAddress(DataAccessLayer.Address address);

        [OperationContract]
        void DeleteAddress(int id);

        [OperationContract]
        void UpdateAddress(int id, DataAccessLayer.Address address);

        [OperationContract]
        Address GetSingleAddress(int id);

        //LegalEntity
        [OperationContract]
        List<LegalEntity> GetAllLegalEntities();

        [OperationContract]
        void CreateLegalEntities(LegalEntity legalEntity);

        [OperationContract]
        void DeleteLegalEntities(int id);

        [OperationContract]
        void UpdateLegalEntities(int id, LegalEntity legalEntity);

        [OperationContract]
        LegalEntity GetSingleLegalEntity(int id);
       
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   /* [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }*/
}
