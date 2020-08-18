using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ChocolateCake : Cake
    {
        public ChocolateCake()
        {
            _treatments = new Treatment[]
            {
                new BakeInOvenTreatment()
            };
        }
        protected override void GetIngredients()
        {
            
        }

        protected override void PrepareIngredients()
        {
            throw new NotImplementedException();
        }

        protected override void MixIngredients()
        {
            throw new NotImplementedException();
        }

        protected override void PreCool()
        {
            Wait();
        }

        protected override void MakeParts()
        {
            CutInHalf(0);
            CutInHalf(45);
            CutInHalf(90);
        }

        protected override void PostCool()
        {
            throw new NotImplementedException();
        }

        protected override void Wrap()
        {
            throw new NotImplementedException();
        }
    }
}
