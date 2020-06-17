#include "Modules/ModuleInterface.h"
#include "Modules/ModuleManager.h"

DEFINE_LOG_CATEGORY_STATIC(LogTxtAsset, Log, All)

class FTxtAssetModule 
	: public IModuleInterface
{
public:
	virtual void StartupModule() override
	{
		//UE_Log语句后必须加分号(;)，否则无效，根本不输出Log
		UE_LOG(LogTxtAsset, Warning, TEXT("FTxtAssetModule::StartupModule()"));
	}

	virtual void ShutdownModule() override
	{

	}

protected:
private:
};

IMPLEMENT_MODULE(FTxtAssetModule, TxtAsset)