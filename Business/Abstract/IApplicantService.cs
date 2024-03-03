using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        //interfaceler mueyyen method imzalarini ozunde tutub bir birinin alternativi olan sistemlerin ferqli implemetasiya elemelerine yarayarlar
        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);
    }
}
