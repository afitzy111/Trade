using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class LegalEntityClass
    {
        //Retrieve all Legal Entities method
        public List<LegalEntity> GetLegalEntities()
        {
            using (TradingDatabaseEntities context = new TradingDatabaseEntities())
            {
                List<LegalEntity> allLegalEntities = new List<LegalEntity>();
                foreach (LegalEntity l in context.LegalEntities)
                {
                    allLegalEntities.Add(l);
                }
                return allLegalEntities;
            }
        }

        //Create new legal entity
        public void CreateLegalEntity(LegalEntity legalEntity)
        {
            using (TradingDatabaseEntities context = new TradingDatabaseEntities())
            {
                if (legalEntity == null)
                {
                    context.LegalEntities.Add(legalEntity);
                    context.SaveChanges();
                }
            }
        }

        //Method to delete a Legal Entity
        public void DeleteLegalEntity(int id)
        {
            using (TradingDatabaseEntities context = new TradingDatabaseEntities())
            {
                LegalEntity legalEntityToDelete = (from l in context.LegalEntities
                                           where l.id == id
                                           select l).FirstOrDefault();
                if (legalEntityToDelete != null)
                {
                    context.LegalEntities.Remove(legalEntityToDelete);
                    context.SaveChanges();
                }
            }
        }

        //Method to update an existing legal entity
        public void UpdateLegalEntity(int id, LegalEntity newLegalEntity)
        {
            using (TradingDatabaseEntities context = new TradingDatabaseEntities())
            {
                LegalEntity legalEntityToUpdate = (from l in context.LegalEntities
                                           where l.id == id
                                           select l).FirstOrDefault();
                if (newLegalEntity != null)
                {
                    legalEntityToUpdate.Name = legalEntityToUpdate.Name;
                    legalEntityToUpdate.Address = legalEntityToUpdate.Address;

                    context.SaveChanges();
                }
            }
        }

        //Method to retrieve a single Legal Entity
        public LegalEntity GetSingleLegalEntity(int id)
        {
            using (TradingDatabaseEntities context = new TradingDatabaseEntities())
            {
                LegalEntity LegalEntityToFind = (from l in context.LegalEntities
                                                 where l.id == id
                                                 select l).FirstOrDefault();

                return LegalEntityToFind;
            }

        }
    }
}
