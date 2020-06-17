#pragma once

#include "UObject/Object.h"
#include "UObject/ObjectMacros.h"

// UCLASS������� xxx.generated.h, �ұ��������һ��include��
#include "TxtAsset.generated.h"

UCLASS(BlueprintType)
class TXTASSET_API UTxtAsset
	: public UObject
{
	// UCLASS������UHT�Զ����ɵĴ���
	// �̳���UObject��ʹ��GENERATED_BODY��
	// ע�����û�ֺ� (;), �����������е�һ��
	GENERATED_BODY()

public:
	UPROPERTY(BlueprintReadOnly, EditAnywhere, Category = "TxtAsset")
		FText Txt;

	UPROPERTY(BlueprintReadOnly, EditDefaultsOnly, Category = "TxtAsset")
		float Len;

protected:
private:
};
