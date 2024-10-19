using System;

namespace OpenMeteo;
public record MetadataModel(
    DateTime DataEndTime,
    DateTime LastRunAvailabilityTime,
    DateTime LastRunInitialisationTime,
    DateTime LastRunModificationTime,
    int TemporalResolutionSeconds,
    int UpdateIntervalSeconds
);
