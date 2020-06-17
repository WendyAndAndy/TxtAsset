#pragma once

#include "UObject/Object.h"
#include "UObject/ObjectMacros.h"

// UCLASS必须包含 xxx.generated.h, 且必须是最后一个include项
#include "TxtAsset.generated.h"

UCLASS(BlueprintType)
class TXTASSET_API UTxtAsset
	: public UObject
{
	// UCLASS都含有UHT自动生成的代码
	// 继承自UObject的使用GENERATED_BODY宏
	// 注意后面没分号 (;), 放在类声明中第一行
	GENERATED_BODY()

public:
	UPROPERTY(BlueprintReadOnly, EditAnywhere, Category = "TxtAsset")
		FText Txt;

	UPROPERTY(BlueprintReadOnly, EditDefaultsOnly, Category = "TxtAsset")
		float Len;

protected:
private:
};
