using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExercise2
{
    public interface IDataAccess
    {

        public void SaveData();

        public List<Product> LoadData();
        
    }
}


