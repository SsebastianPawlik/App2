﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatFORMS
{
    delegate string GetSecretIngredient(int amount);
    internal class Suzanne
    {
        public GetSecretIngredient MySecretIngredientMethod
        {
            get
            {
                return new GetSecretIngredient(SuzannesSecretIngredient);
            }
        }
        private string SuzannesSecretIngredient(int amount)
        {
            return amount.ToString() + " dekagramów goździków";
        }
    }
}
