using System;

public interface ITransaction
{
    void InsertTransaction(long _UserBankAccountId, TransactionType _tranType, decimal _tranAmount, string _desc);
    void ViewTransaction();
}
