using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PNTask01
{
	/// <summary>
	/// Task1. Implement "VNPayService" and "MOMOService" classes
	/// which derived from this interface.
	/// as for in/out data,  refer to <see cref="UnitTest1.VNPayTest"/>.
	/// other than this, need to implement frontend and Web API Callback.
	/// </summary>
	public interface IPaymentService
	{
		//1. Constructor( is injected by DI container. 
		// you can implement "Setting" class freely as argument.
		// "Setting" should to be easy to serialize)

		/// <summary>
		/// 2. Pay by service.
		/// </summary>
		/// <param name="id">user identity. it decide an account on the service. </param>
		/// <param name="description">transaction's description</param>
		/// <param name="amount">amount to pay or deposit </param>
		/// <param name="currency">currency symbol. 3 upper chars</param>
		/// <param name="depositMode">
		/// if this is true, just deposit, not pay.
		/// if API doesn't support deposit, process payment and refund later. </param>
		/// <returns>
		/// "object" means service API's Transaction class. 
		/// "string" means error message. if successful, return null.
		/// </returns>
		Tuple<object, string> Pay(string id, string description,
			decimal amount, string currency = "USD", bool depositMode = false);

		IEnumerable<string> SupportedCurrencies { get; }

		/// <summary>
		/// Refund. cancel transaction.
		/// </summary>
		/// <param name="transaction">transaction</param>
		/// <returns>error message. if successful, return null.</returns>
		string Refund(object transaction);

		/// <summary>
		/// Deduct from deposit.
		/// if API don't support deposit, refund (amount - confirmedAmount).
		/// </summary>
		/// <param name="depositTransaction">deposit transaction</param>
		/// <param name="confirmedAmount">less than Transaction.Amount</param>
		/// <returns>error message. if successful, return null.</returns>
		string DeductFromDeposit(object depositTransaction, decimal confirmedAmount);

		/// <summary>
		/// call register process.
		/// show UI for user to fill his information(username, payment info, vv)
		/// and receive userId.
		/// this method have to be re-written according to platform,
		/// so you can implement freely (call every necessary API).
		/// </summary>
		/// <returns>userId</returns>
		Task<string> RegisterUser();

		/// <summary>
		/// unregister user
		/// </summary>
		/// <param name="userId"></param>
		/// <returns>error message. if successful, return null.</returns>
		string UnregisterUser(string userId);
	}

	public class VNPayService : IPaymentService
	{
		public class Setting
		{
			
		}

		public VNPayService(Setting setting)
		{
			throw new NotImplementedException();
		}
		
		
		public Tuple<object, string> Pay(string id, string description, decimal amount, string currency = "USD", bool depositMode = false)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<string> SupportedCurrencies
		{
			get
			{
				throw new NotImplementedException();
			}
		}
		
		public string Refund(object transaction)
		{
			throw new NotImplementedException();
		}

		public string DeductFromDeposit(object depositTransaction, decimal confirmedAmount)
		{
			throw new NotImplementedException();
		}

		public Task<string> RegisterUser()
		{
			throw new NotImplementedException();
		}

		public string UnregisterUser(string userId)
		{
			throw new NotImplementedException();
		}
	}
}