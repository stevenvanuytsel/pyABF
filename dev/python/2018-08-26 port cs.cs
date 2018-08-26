


var fFileSignature = readStruct(fb, "4s", 0)
float fFileVersionNumber = readStruct(fb, "f", 4)
short nOperationMode = readStruct(fb, "h", 8)
int lActualAcqLength = readStruct(fb, "i", 10)
short nNumPointsIgnored = readStruct(fb, "h", 14)
int lActualEpisodes = readStruct(fb, "i", 16)
int lFileStartTime = readStruct(fb, "i", 24)
int lDataSectionPtr = readStruct(fb, "i", 40)
int lTagSectionPtr = readStruct(fb, "i", 44)
int lNumTagEntries = readStruct(fb, "i", 48)
int lSynchArrayPtr = readStruct(fb, "i", 92)
int lSynchArraySize = readStruct(fb, "i", 96)
short nDataFormat = readStruct(fb, "h", 100)
short nADCNumChannels = readStruct(fb, "h", 120)
float fADCSampleInterval = readStruct(fb, "f", 122)
float fSynchTimeUnit = readStruct(fb, "f", 130)
int lNumSamplesPerEpisode = readStruct(fb, "i", 138)
int lPreTriggerSamples = readStruct(fb, "i", 142)
int lEpisodesPerRun = readStruct(fb, "i", 146)
float fADCRange = readStruct(fb, "f", 244)
int lADCResolution = readStruct(fb, "i", 252)
short nFileStartMillisecs = readStruct(fb, "h", 366)
var nADCPtoLChannelMap = readStruct(fb, "16h", 378)
var nADCSamplingSeq = readStruct(fb, "16h", 410)
var sADCChannelName = readStruct(fb, "10s"*16, 442)
var sADCUnits = readStruct(fb, "8s"*16, 602)
var fADCProgrammableGain = readStruct(fb, "16f", 730)
var fInstrumentScaleFactor = readStruct(fb, "16f", 922)
var fInstrumentOffset = readStruct(fb, "16f", 986)
var fSignalGain = readStruct(fb, "16f", 1050)
var fSignalOffset = readStruct(fb, "16f", 1114)
short nDigitalEnable = readStruct(fb, "h", 1436)
short nActiveDACChannel = readStruct(fb, "h", 1440)
short nDigitalHolding = readStruct(fb, "h", 1584)
short nDigitalInterEpisode = readStruct(fb, "h", 1586)
var nDigitalValue = readStruct(fb, "10h", 2588)
var lDACFilePtr = readStruct(fb, "2i", 2048)
var lDACFileNumEpisodes = readStruct(fb, "2i", 2056)
var fDACCalibrationFactor = readStruct(fb, "4f", 2074)
var fDACCalibrationOffset = readStruct(fb, "4f", 2090)
var nWaveformEnable = readStruct(fb, "2h", 2296)
var nWaveformSource = readStruct(fb, "2h", 2300)
var nInterEpisodeLevel = readStruct(fb, "2h", 2304)
var nEpochType = readStruct(fb, "20h", 2308)
var fEpochInitLevel = readStruct(fb, "20f", 2348)
var fEpochLevelInc = readStruct(fb, "20f", 2428)
var lEpochInitDuration = readStruct(fb, "20i", 2508)
var lEpochDurationInc = readStruct(fb, "20i", 2588)
var nTelegraphEnable = readStruct(fb, "16h", 4512)
var fTelegraphAdditGain = readStruct(fb, "16f", 4576)
var sProtocolPath = readStruct(fb, "384s", 4898)

var fFileSignature = readStruct(fb, "4s")  
var fFileVersionNumber = readStruct(fb, "4b")  
unsigned int uFileInfoSize = readStruct(fb, "I")  
unsigned int lActualEpisodes = readStruct(fb, "I")  
unsigned int uFileStartDate = readStruct(fb, "I")  
unsigned int uFileStartTimeMS = readStruct(fb, "I")  
unsigned int uStopwatchTime = readStruct(fb, "I")  
var nFileType = readStruct(fb, "H")  
var nDataFormat = readStruct(fb, "H")  
var nSimultaneousScan = readStruct(fb, "H")  
var nCRCEnable = readStruct(fb, "H")  
unsigned int uFileCRC = readStruct(fb, "I")  
var uFileGUID = readStruct(fb, "16B")  
var uCreatorVersion = readStruct(fb, "4B")  
unsigned int uCreatorNameIndex = readStruct(fb, "I")  
unsigned int uModifierVersion = readStruct(fb, "I")  
unsigned int uModifierNameIndex = readStruct(fb, "I")  
unsigned int uProtocolPathIndex = readStruct(fb, "I")  

var ProtocolSection = readStruct(fb, "IIl", 76)
var ADCSection = readStruct(fb, "IIl", 92)
var DACSection = readStruct(fb, "IIl", 108)
var EpochSection = readStruct(fb, "IIl", 124)
var ADCPerDACSection = readStruct(fb, "IIl", 140)
var EpochPerDACSection = readStruct(fb, "IIl", 156)
var UserListSection = readStruct(fb, "IIl", 172)
var StatsRegionSection = readStruct(fb, "IIl", 188)
var MathSection = readStruct(fb, "IIl", 204)
var StringsSection = readStruct(fb, "IIl", 220)
var DataSection = readStruct(fb, "IIl", 236)
var TagSection = readStruct(fb, "IIl", 252)
var ScopeSection = readStruct(fb, "IIl", 268)
var DeltaSection = readStruct(fb, "IIl", 284)
var VoiceTagSection = readStruct(fb, "IIl", 300)
var SynchArraySection = readStruct(fb, "IIl", 316)
var AnnotationSection = readStruct(fb, "IIl", 332)
var StatsSection = readStruct(fb, "IIl", 348)

short nOperationMode = readStruct(fb, "h")  
float fADCSequenceInterval = readStruct(fb, "f")  
signed char bEnableFileCompression = readStruct(fb, "b")  
var sUnused = readStruct(fb, "3c")  
unsigned int uFileCompressionRatio = readStruct(fb, "I")  
float fSynchTimeUnit = readStruct(fb, "f")  
float fSecondsPerRun = readStruct(fb, "f")  
int lNumSamplesPerEpisode = readStruct(fb, "i")  
int lPreTriggerSamples = readStruct(fb, "i")  
int lEpisodesPerRun = readStruct(fb, "i")  
int lRunsPerTrial = readStruct(fb, "i")  
int lNumberOfTrials = readStruct(fb, "i")  
short nAveragingMode = readStruct(fb, "h")  
short nUndoRunCount = readStruct(fb, "h")  
short nFirstEpisodeInRun = readStruct(fb, "h")  
float fTriggerThreshold = readStruct(fb, "f")  
short nTriggerSource = readStruct(fb, "h")  
short nTriggerAction = readStruct(fb, "h")  
short nTriggerPolarity = readStruct(fb, "h")  
float fScopeOutputInterval = readStruct(fb, "f")  
float fEpisodeStartToStart = readStruct(fb, "f")  
float fRunStartToStart = readStruct(fb, "f")  
int lAverageCount = readStruct(fb, "i")  
float fTrialStartToStart = readStruct(fb, "f")  
short nAutoTriggerStrategy = readStruct(fb, "h")  
float fFirstRunDelayS = readStruct(fb, "f")  
short nChannelStatsStrategy = readStruct(fb, "h")  
int lSamplesPerTrace = readStruct(fb, "i")  
int lStartDisplayNum = readStruct(fb, "i")  
int lFinishDisplayNum = readStruct(fb, "i")  
short nShowPNRawData = readStruct(fb, "h")  
float fStatisticsPeriod = readStruct(fb, "f")  
int lStatisticsMeasurements = readStruct(fb, "i")  
short nStatisticsSaveStrategy = readStruct(fb, "h")  
float fADCRange = readStruct(fb, "f")  
float fDACRange = readStruct(fb, "f")  
int lADCResolution = readStruct(fb, "i")  
int lDACResolution = readStruct(fb, "i")  
short nExperimentType = readStruct(fb, "h")  
short nManualInfoStrategy = readStruct(fb, "h")  
short nCommentsEnable = readStruct(fb, "h")  
int lFileCommentIndex = readStruct(fb, "i")  
short nAutoAnalyseEnable = readStruct(fb, "h")  
short nSignalType = readStruct(fb, "h")  
short nDigitalEnable = readStruct(fb, "h")  
short nActiveDACChannel = readStruct(fb, "h")  
short nDigitalHolding = readStruct(fb, "h")  
short nDigitalInterEpisode = readStruct(fb, "h")  
short nDigitalDACChannel = readStruct(fb, "h")  
short nDigitalTrainActiveLogic = readStruct(fb, "h")  
short nStatsEnable = readStruct(fb, "h")  
short nStatisticsClearStrategy = readStruct(fb, "h")  
short nLevelHysteresis = readStruct(fb, "h")  
int lTimeHysteresis = readStruct(fb, "i")  
short nAllowExternalTags = readStruct(fb, "h")  
short nAverageAlgorithm = readStruct(fb, "h")  
float fAverageWeighting = readStruct(fb, "f")  
short nUndoPromptStrategy = readStruct(fb, "h")  
short nTrialTriggerSource = readStruct(fb, "h")  
short nStatisticsDisplayStrategy = readStruct(fb, "h")  
short nExternalTagType = readStruct(fb, "h")  
short nScopeTriggerOut = readStruct(fb, "h")  
short nLTPType = readStruct(fb, "h")  
short nAlternateDACOutputState = readStruct(fb, "h")  
short nAlternateDigitalOutputState = readStruct(fb, "h")  
var fCellID = readStruct(fb, "3f")  
short nDigitizerADCs = readStruct(fb, "h")  
short nDigitizerDACs = readStruct(fb, "h")  
short nDigitizerTotalDigitalOuts = readStruct(fb, "h")  
short nDigitizerSynchDigitalOuts = readStruct(fb, "h")  
short nDigitizerType = readStruct(fb, "h")  

short nADCNum[i] = readStruct(fb, "h")  
short nTelegraphEnable[i] = readStruct(fb, "h")  
short nTelegraphInstrument[i] = readStruct(fb, "h")  
float fTelegraphAdditGain[i] = readStruct(fb, "f")  
float fTelegraphFilter[i] = readStruct(fb, "f")  
float fTelegraphMembraneCap[i] = readStruct(fb, "f")  
short nTelegraphMode[i] = readStruct(fb, "h")  
float fTelegraphAccessResistance[i] = readStruct(fb, "f")  
short nADCPtoLChannelMap[i] = readStruct(fb, "h")  
short nADCSamplingSeq[i] = readStruct(fb, "h")  
float fADCProgrammableGain[i] = readStruct(fb, "f")  
float fADCDisplayAmplification[i] = readStruct(fb, "f")  
float fADCDisplayOffset[i] = readStruct(fb, "f")  
float fInstrumentScaleFactor[i] = readStruct(fb, "f")  
float fInstrumentOffset[i] = readStruct(fb, "f")  
float fSignalGain[i] = readStruct(fb, "f")  
float fSignalOffset[i] = readStruct(fb, "f")  
float fSignalLowpassFilter[i] = readStruct(fb, "f")  
float fSignalHighpassFilter[i] = readStruct(fb, "f")  
signed char nLowpassFilterType[i] = readStruct(fb, "b")  
signed char nHighpassFilterType[i] = readStruct(fb, "b")  
float fPostProcessLowpassFilter[i] = readStruct(fb, "f")  
char nPostProcessLowpassFilterType[i] = readStruct(fb, "c")  
signed char bEnabledDuringPN[i] = readStruct(fb, "b")  
short nStatsChannelPolarity[i] = readStruct(fb, "h")  
int lADCChannelNameIndex[i] = readStruct(fb, "i")  
int lADCUnitsIndex[i] = readStruct(fb, "i")  

short nDACNum[i] = readStruct(fb, "h")  
short nTelegraphDACScaleFactorEnable[i] = readStruct(fb, "h")  
float fInstrumentHoldingLevel[i] = readStruct(fb, "f")  
float fDACScaleFactor[i] = readStruct(fb, "f")  
float fDACHoldingLevel[i] = readStruct(fb, "f")  
float fDACCalibrationFactor[i] = readStruct(fb, "f")  
float fDACCalibrationOffset[i] = readStruct(fb, "f")  
int lDACChannelNameIndex[i] = readStruct(fb, "i")  
int lDACChannelUnitsIndex[i] = readStruct(fb, "i")  
int lDACFilePtr[i] = readStruct(fb, "i")  
int lDACFileNumEpisodes[i] = readStruct(fb, "i")  
short nWaveformEnable[i] = readStruct(fb, "h")  
short nWaveformSource[i] = readStruct(fb, "h")  
short nInterEpisodeLevel[i] = readStruct(fb, "h")  
float fDACFileScale[i] = readStruct(fb, "f")  
float fDACFileOffset[i] = readStruct(fb, "f")  
int lDACFileEpisodeNum[i] = readStruct(fb, "i")  
short nDACFileADCNum[i] = readStruct(fb, "h")  
short nConditEnable[i] = readStruct(fb, "h")  
int lConditNumPulses[i] = readStruct(fb, "i")  
float fBaselineDuration[i] = readStruct(fb, "f")  
float fBaselineLevel[i] = readStruct(fb, "f")  
float fStepDuration[i] = readStruct(fb, "f")  
float fStepLevel[i] = readStruct(fb, "f")  
float fPostTrainPeriod[i] = readStruct(fb, "f")  
float fPostTrainLevel[i] = readStruct(fb, "f")  
short nMembTestEnable[i] = readStruct(fb, "h")  
short nLeakSubtractType[i] = readStruct(fb, "h")  
short nPNPolarity[i] = readStruct(fb, "h")  
float fPNHoldingLevel[i] = readStruct(fb, "f")  
short nPNNumADCChannels[i] = readStruct(fb, "h")  
short nPNPosition[i] = readStruct(fb, "h")  
short nPNNumPulses[i] = readStruct(fb, "h")  
float fPNSettlingTime[i] = readStruct(fb, "f")  
float fPNInterpulse[i] = readStruct(fb, "f")  
short nLTPUsageOfDAC[i] = readStruct(fb, "h")  
short nLTPPresynapticPulses[i] = readStruct(fb, "h")  
int lDACFilePathIndex[i] = readStruct(fb, "i")  
float fMembTestPreSettlingTimeMS[i] = readStruct(fb, "f")  
float fMembTestPostSettlingTimeMS[i] = readStruct(fb, "f")  
short nLeakSubtractADCIndex[i] = readStruct(fb, "h")  

short nEpochNum[i] = readStruct(fb, "h")  
short nDACNum[i] = readStruct(fb, "h")  
short nEpochType[i] = readStruct(fb, "h")  
float fEpochInitLevel[i] = readStruct(fb, "f")  
float fEpochLevelInc[i] = readStruct(fb, "f")  
int lEpochInitDuration[i] = readStruct(fb, "i")  
int lEpochDurationInc[i] = readStruct(fb, "i")  
int lEpochPulsePeriod[i] = readStruct(fb, "i")  
int lEpochPulseWidth[i] = readStruct(fb, "i")  

short nEpochNum[i] = readStruct(fb, "h")  
short nEpochDigitalOutput[i] = readStruct(fb, "h")  

int lTagTime[i] = readStruct(fb, "i")
var sComment[i] = readStruct(fb, "56s")
short nTagType[i] = readStruct(fb, "h")
short nVoiceTagNumberorAnnotationIndex[i] = readStruct(fb, "h")

var strings[i] = readStruct(fb, structFormat, cleanStrings=False)
