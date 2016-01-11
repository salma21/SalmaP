﻿using Data.Infrastructure;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class GestionContratetSocService : IGestionContratetSocService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork utOfWork = new UnitOfWork(dbFactory);

        public GestionContratetSocService() { }

        //public IEnumerable<Contrat_maintenance> GetContrat_maintenances()
        //{
        //    var dep = utOfWork.ContratMaintennaceRepository.GetAll();
        //    return dep;
        //}
        //public IEnumerable<Contrat_garanti> GetContrat_garantis()
        //{
        //    var dep = utOfWork.ContratGarantieRepository.GetAll();
        //    return dep;
        //}
        //public IEnumerable<Contrat_assurance> GetContrat_assurances()
        //{
        //    var dep = utOfWork.ContratAssuranceRepository.GetAll();
        //    return dep;
        //}
        //public IEnumerable<Societe_maintenance> GetSociete_maintenances()
        //{
        //    var dep = utOfWork.SocieteMaintenanceRepository.GetAll();
        //    return dep;
        //}
        //public IEnumerable<Societe_assurance> GetSociete_assurances()
        //{
        //    var dep = utOfWork.SocieteAssuranceRepository.GetAll();
        //    return dep;
        //}
        //public IEnumerable<Achat> GetAchat()
        //{
        //    var dep = utOfWork.AchatRepository.GetAll();
        //    return dep;
        //}


     



        public void SaveChange()
        {
            utOfWork.Commit();
        }


       

        public void UpdateAchatDetached(Achat e)
        {
            utOfWork.AchatRepository.UpdateAchatDetached(e);
        }
        
    }
    public interface IGestionContratetSocService
    {
       
       
        void UpdateAchatDetached(Achat e);

        void SaveChange();
     }

}


