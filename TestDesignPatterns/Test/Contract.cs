using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDesignPatterns.Example_Contracts
{
    public abstract class Contract
    {
        private int mContractId = 0;
        private string mContractName = string.Empty;
        private DateTime mEffectiveDate;
        private DateTime mExpirationDate;

    }
}
