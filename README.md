# MornTween

## 概要

非同期トゥイーンアニメーションシステム。値の時間補間を行うライブラリ。

## 依存関係

| 種別 | 名前 |
|------|------|
| 外部パッケージ | UniTask |
| Mornライブラリ | MornEase, MornLib |

## 使い方

### 基本的な使用方法

```csharp
var tween = new MornTween<Vector3>(
    getter: () => transform.position,
    setter: v => transform.position = v,
    lerp: Vector3.Lerp,
    endValue: targetPos,
    duration: 1f,
    easeType: MornEaseType.EaseOutQuad
);

// UniTaskでawait可能
await tween;
```

### パラメータ

| パラメータ | 説明 |
|-----------|------|
| getter | 現在値を取得する関数 |
| setter | 値を設定する関数 |
| lerp | 補間関数 |
| endValue | 終了値 |
| duration | 期間（秒） |
| easeType | イージングタイプ |
