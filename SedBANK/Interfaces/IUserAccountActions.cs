using System;
using System.Collections.Generic;
using System.Text;

namespace SedBANK.Interfaces
{
    public interface IUserAccountActions
    {
        void CheckBalance();
        void PlaceDeposit();
        void MakeWithDrawal();
    }
}
