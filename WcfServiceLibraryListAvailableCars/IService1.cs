﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryListAvailableCars
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        
        List<RentC.DTO.CarsDTO> ListCars();

    }
  
}
