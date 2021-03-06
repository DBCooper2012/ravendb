using Raven.Bundles.Tests.Authentication;
using Raven.Bundles.Tests.Replication;
using Xunit;

namespace Raven.StressTests.Races
{
	public class BundelsRaceConditions : StressTest
	{
		[Fact]
		public void FailoverBetweenTwoMultiTenantDatabases_CanReplicateBetweenTwoMultiTenantDatabases()
		{
			Run<FailoverBetweenTwoMultiTenantDatabases>(x => x.CanReplicateBetweenTwoMultiTenantDatabases(), 10000);
		}
		
		[Fact]
		public void FailoverBetweenTwoMultiTenantDatabases_CanFailoverReplicationBetweenTwoMultiTenantDatabases()
		{
			Run<FailoverBetweenTwoMultiTenantDatabases>(x => x.CanFailoverReplicationBetweenTwoMultiTenantDatabases(), 10000);
		}

		[Fact]
		public void FailoverBetweenTwoMultiTenantDatabases_CanFailoverReplicationBetweenTwoMultiTenantDatabases_WithExplicitUrl()
		{
			Run<FailoverBetweenTwoMultiTenantDatabases>(x => x.CanFailoverReplicationBetweenTwoMultiTenantDatabases_WithExplicitUrl(), 10000);
		}

		[Fact]
		public void SimpleLogin()
		{
			Run<SimpleLogin>(x => x.WillGetAnErrorWhenTryingToLoginIfUserDoesNotExists());
		}


		[Fact]
		public void AsyncSimpleLogin()
		{
			Run<AsyncSimpleLogin>(x => x.WillGetAnErrorWhenTryingToLoginIfUserDoesNotExists());
		}
	}
}