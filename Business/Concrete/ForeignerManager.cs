﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    //Sonar Qube
    public class ForeignerManager : IApplicantService
    {
        //eyer bir proyektde ne qeder if varsa o proyekt o qeder proqramlasdirma prinsiplerine uzaqdir.
        //bir proqlamlasdirma keyfiyyet olcum programi var Sonar Cube.
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
