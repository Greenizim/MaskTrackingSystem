using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager
    {
        //burda pttmanagerin bagimli oldugu sinif evezine o siniflerin interfaceini yaziriq
        //bunlar fielddir ve calssin icinde _ le yazilir
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService) //Constructor new edildiyinde isleyir
        {                   //iki sinifin referansini ozunde tutur
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {

            if (_applicantService.CheckPerson (person)) 
            {
                Console.WriteLine( person.FirstName + " given a mask");
            }

            else
            {
                Console.WriteLine(person.FirstName + " was not given a mask");
            }

            //PttManager pttManager = new PttManager(new ForeignerManager());
            //bir sinif basqa bir sinifi istifade ederken entityler xaric newleyirse eger gelecek ucun bu kodda deyisiklik telebi gelende bu proqram asililiq gosterecekdir.
            //PersonManager personManager = new PersonManager();
            //if (personManager.CheckPerson(person))
            //{
            //    Console.WriteLine(person.FirstName + " given a mask");
            //}
        }
    }
}
