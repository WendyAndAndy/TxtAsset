#include "Modules/ModuleInterface.h"
#include "Modules/ModuleManager.h"

DEFINE_LOG_CATEGORY_STATIC(LogTxtAsset, Log, All)

class FTxtAssetModule 
	: public IModuleInterface
{
public:
	virtual void StartupModule() override
	{
		//UE_Log�������ӷֺ�(;)��������Ч�����������Log
		UE_LOG(LogTxtAsset, Warning, TEXT("FTxtAssetModule::StartupModule()"));
	}

	virtual void ShutdownModule() override
	{

	}

protected:
private:
};

IMPLEMENT_MODULE(FTxtAssetModule, TxtAsset)