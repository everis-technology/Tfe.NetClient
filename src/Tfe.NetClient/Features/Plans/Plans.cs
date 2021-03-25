using System;

namespace Tfe.NetClient.Plans
{
	public class PlansResponse
	{
		public Data Data { get; set; }
	}

	public class Data
	{
		public string Id { get; set; }

		public string Type { get; set; }

		public PlanAttributes Attributes { get; set; }

		public PlansRelationships PlansRelationships { get; set; }

		public PlanLinks Links { get; set; }
	}

	public class PlanAttributes
	{
		public bool HasChanges { get; set; }

		public string Status { get; set; }

		public PlansStatusTimestamps PlansStatusTimestamps { get; set; }

		public Uri LogReadUrl { get; set; }

		public int? ResourceAdditions { get; set; }

		public int? ResourceChanges { get; set; }

		public int? ResourceDestructions { get; set; }

		public PlansActions PlansActions { get; set; }

		public ExecutionDetails ExecutionDetails { get; set; }

		public PlansPermissions PlansPermissions { get; set; }
	}

	public class PlansStatusTimestamps
	{
		public DateTime StartedAt { get; set; }

		public DateTime FinishedAt { get; set; }

		public DateTime ManagedQueuedAt { get; set; }
	}

	public class PlansActions
	{
		public bool IsExportable { get; set; }
	}

	public class ExecutionDetails
	{
		public string Mode { get; set; }
	}

	public class PlansPermissions
	{
		public bool CanExport { get; set; }
	}

	public class PlansRelationships
	{
		public StateVersions StateVersions { get; set; }

		public Exports Exports { get; set; }
	}

	public class StateVersions
	{
		public object[] Data { get; set; }
	}

	public class Exports
	{
		public object[] Data { get; set; }
	}

	public class PlanLinks
	{
		public string Self { get; set; }

		public string JsonOutput { get; set; }
	}
}