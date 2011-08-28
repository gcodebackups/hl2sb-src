// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamGameServer004VTable
	{
		public IntPtr LogOn0;
		public IntPtr LogOff1;
		public IntPtr BLoggedOn2;
		public IntPtr BSecure3;
		public IntPtr GetSteamID4;
		public IntPtr SendUserConnectAndAuthenticate5;
		public IntPtr CreateUnauthenticatedUserConnection6;
		public IntPtr SendUserDisconnect7;
		public IntPtr BUpdateUserData8;
		public IntPtr BSetServerType9;
		public IntPtr UpdateStatus10;
		public IntPtr UpdateSpectatorPort11;
		public IntPtr SetGameType12;
		public IntPtr BGetUserAchievementStatus13;
		private IntPtr DTorISteamGameServer00414;
	};
	
	[InteropHelp.InterfaceVersion("SteamGameServer004")]
	public class ISteamGameServer004 : InteropHelp.NativeWrapper<ISteamGameServer004VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLogOn( IntPtr thisptr );
		public void LogOn(  ) 
		{
			this.GetFunction<NativeLogOn>( this.Functions.LogOn0 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLogOff( IntPtr thisptr );
		public void LogOff(  ) 
		{
			this.GetFunction<NativeLogOff>( this.Functions.LogOff1 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBLoggedOn( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BLoggedOn(  ) 
		{
			return this.GetFunction<NativeBLoggedOn>( this.Functions.BLoggedOn2 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBSecure( IntPtr thisptr );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BSecure(  ) 
		{
			return this.GetFunction<NativeBSecure>( this.Functions.BSecure3 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetSteamID( IntPtr thisptr, ref UInt64 retarg );
		public CSteamID GetSteamID(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetSteamID>( this.Functions.GetSteamID4 )( this.ObjectAddress, ref ret ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendUserConnectAndAuthenticateCUBU( IntPtr thisptr, UInt64 steamIDUser, UInt32 arg1, Byte[] arg2, UInt32 arg3 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SendUserConnectAndAuthenticate( CSteamID steamIDUser, UInt32 arg1, Byte[] arg2, UInt32 arg3 ) 
		{
			return this.GetFunction<NativeSendUserConnectAndAuthenticateCUBU>( this.Functions.SendUserConnectAndAuthenticate5 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), arg1, arg2, arg3 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeCreateUnauthenticatedUserConnection( IntPtr thisptr, ref UInt64 retarg );
		public CSteamID CreateUnauthenticatedUserConnection(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeCreateUnauthenticatedUserConnection>( this.Functions.CreateUnauthenticatedUserConnection6 )( this.ObjectAddress, ref ret ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSendUserDisconnectC( IntPtr thisptr, UInt64 steamIDUser );
		public void SendUserDisconnect( CSteamID steamIDUser ) 
		{
			this.GetFunction<NativeSendUserDisconnectC>( this.Functions.SendUserDisconnect7 )( this.ObjectAddress, steamIDUser.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBUpdateUserDataCSU( IntPtr thisptr, UInt64 steamIDUser, string pchPlayerName, UInt32 uScore );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BUpdateUserData( CSteamID steamIDUser, string pchPlayerName, UInt32 uScore ) 
		{
			return this.GetFunction<NativeBUpdateUserDataCSU>( this.Functions.BUpdateUserData8 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchPlayerName, uScore ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBSetServerTypeIUUUUUSSB( IntPtr thisptr, Int32 nGameAppId, UInt32 unServerFlags, UInt32 unGameIP, UInt16 unGamePort, UInt16 usSpectatorPort, UInt16 usQueryPort, string pchGameDir, string pchVersion, [MarshalAs(UnmanagedType.I1)] bool bLANMode );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BSetServerType( Int32 nGameAppId, UInt32 unServerFlags, UInt32 unGameIP, UInt16 unGamePort, UInt16 usSpectatorPort, UInt16 usQueryPort, string pchGameDir, string pchVersion, bool bLANMode ) 
		{
			return this.GetFunction<NativeBSetServerTypeIUUUUUSSB>( this.Functions.BSetServerType9 )( this.ObjectAddress, nGameAppId, unServerFlags, unGameIP, unGamePort, usSpectatorPort, usQueryPort, pchGameDir, pchVersion, bLANMode ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdateStatusIIISSS( IntPtr thisptr, Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pSpectatorServerName, string pchMapName );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool UpdateStatus( Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pSpectatorServerName, string pchMapName ) 
		{
			return this.GetFunction<NativeUpdateStatusIIISSS>( this.Functions.UpdateStatus10 )( this.ObjectAddress, cPlayers, cPlayersMax, cBotPlayers, pchServerName, pSpectatorServerName, pchMapName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeUpdateSpectatorPortU( IntPtr thisptr, UInt16 unSpectatorPort );
		public void UpdateSpectatorPort( UInt16 unSpectatorPort ) 
		{
			this.GetFunction<NativeUpdateSpectatorPortU>( this.Functions.UpdateSpectatorPort11 )( this.ObjectAddress, unSpectatorPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetGameTypeS( IntPtr thisptr, string pchGameType );
		public void SetGameType( string pchGameType ) 
		{
			this.GetFunction<NativeSetGameTypeS>( this.Functions.SetGameType12 )( this.ObjectAddress, pchGameType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBGetUserAchievementStatusCS( IntPtr thisptr, UInt64 steamID, string pchAchievementName );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool BGetUserAchievementStatus( CSteamID steamID, string pchAchievementName ) 
		{
			return this.GetFunction<NativeBGetUserAchievementStatusCS>( this.Functions.BGetUserAchievementStatus13 )( this.ObjectAddress, steamID.ConvertToUint64(), pchAchievementName ); 
		}
		
	};
}