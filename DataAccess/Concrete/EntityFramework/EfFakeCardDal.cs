using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFakeCardDal : IFakeCardDal
    {
        public void Add(FakeCard entity)
        {
            
        }

        public void Delete(FakeCard entity)
        {
            
        }

        public FakeCard Get(Expression<Func<FakeCard, bool>> filter)
        {
            return new FakeCard() { CardCvv="123", CardNumber="163849572537485", Id=123, NameOnTheCard="Yaren" };
        }

        public List<FakeCard> GetAll(Expression<Func<FakeCard, bool>> filter = null)
        {
            return new List<FakeCard>() { 
                new FakeCard { CardCvv = "123", CardNumber = "163849572537485", Id = 123, NameOnTheCard = "Yaren" } ,
                new FakeCard { CardCvv = "175", CardNumber = "153849572537485", Id = 165, NameOnTheCard = "Hande" } ,
                new FakeCard { CardCvv = "937", CardNumber = "103849572537477", Id = 194, NameOnTheCard = "Fırat" } 
            };
        }

        public void Update(FakeCard entity)
        {
            
        }
    }
}
