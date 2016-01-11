﻿using Data.Infrastructure;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BureauService : IBureauService
    {
        static DatabaseFactory dbFactory = new DatabaseFactory();
        IUnitOfWork utOfWork = new UnitOfWork(dbFactory);

        public BureauService() { }

        public IEnumerable<Bureau> GetBureaux()
        {
            var dep = utOfWork.BureauRepository.GetAll();
            return dep;
        }

        public Bureau GetBureau(int id)
        {
            var Dept = utOfWork.BureauRepository.GetById(id);
            return Dept;
        }

        public void CreateBureau(Bureau bureau)
        {

            utOfWork.BureauRepository.Add(bureau);


        }
        public void DeleteBureau(int id)
        {

            var Dept = utOfWork.BureauRepository.GetById(id);
            utOfWork.BureauRepository.Delete(Dept);



        }
        public Bureau FindBureauByID(int id)
        {
            var Dept = utOfWork.BureauRepository.FindBureauByID(id);
            return Dept;

        }



        public void SaveBureau()
        {
            utOfWork.Commit();
        }


        public void UpdateBureauDetached(Bureau e)
        {
            utOfWork.BureauRepository.UpdateBureauDetached(e);
        }



       




    }
    public interface IBureauService
    {
        Bureau FindBureauByID(int id);

        IEnumerable<Bureau> GetBureaux();
        Bureau GetBureau(int id);
        void CreateBureau(Bureau Dept);
        void DeleteBureau(int id);

        void UpdateBureauDetached(Bureau e);


        void SaveBureau();







    }

}


