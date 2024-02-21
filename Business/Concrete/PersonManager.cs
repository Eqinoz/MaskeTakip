using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyMask(Person person)
        {
            
        }

        public  bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(person.TcIdentityNo,person.Name,person.SurName,person.BirthYear).Result.Body.TCKimlikNoDogrulaResult;
        }

        public List<Person> GetList()
        {
            
            return null;
        }
    }
}
