using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using MernisServiceReference;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        ////burda yazacagimiz int string v.s deyisenleri alib bir classa yigmagimiza encapsulation deyilir.
        //public void ApplyForMask(Person person)
        //{

        //}

        ////list icerisinde verdiyimiz tipde listdir
        //public List<Person> GetList()
        //{
        //    return null;
        //}

        //public bool CheckPerson(Person person)
        //{
        //    return true;
        //}

        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }

        public  bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
        //implement edirik akpden
    }
}
