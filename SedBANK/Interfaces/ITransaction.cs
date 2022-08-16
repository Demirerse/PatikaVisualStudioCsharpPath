using SedBANK.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SedBANK.Interfaces
{
    public interface ITransaction
    {
        void InsertTransaction(long _UserBankAccountId, TransactionType _tranType, decimal _tranAmount, string _desc);
        void ViewTransaction();
    }
}
