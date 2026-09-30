# 📦 Parcel Master

Unity로 개발한 **2D 택배 업무 미니게임**입니다.

플레이어는 월드를 탐색해 택배 회사에 입장하고,  
**택배 분류 → 배송**으로 이어지는 두 가지 미니게임을 순차적으로 진행합니다.

<br>

## 🎬 Demo Play

[![Parcel Master Demo](https://img.youtube.com/vi/wRStJXdz-yI/0.jpg)](https://youtu.be/wRStJXdz-yI)

> 이미지를 클릭하면 전체 플레이 영상을 확인할 수 있습니다.

<br>

## 🎮 Game Flow

### 🏢 World

플레이어가 이동하며 게임을 시작할 수 있는 메인 월드입니다.  
택배 회사 건물에 입장하면 첫 번째 미니게임이 시작됩니다.

**World → Parcel Sorting → Delivery**

<br>

### 📦 Stage 1. Parcel Sorting

위에서 무작위로 떨어지는 택배를 확인하고  
종류에 맞게 분류하는 미니게임입니다.

- 택배 오브젝트 랜덤 생성
- 택배 종류에 따른 분류
- 정답 / 오답 판정
- 연속 성공에 따른 Combo 시스템
- 게임 진행 상태 UI

<br>

### 🚚 Stage 2. Delivery

택배 차량을 조작하여 도로에서 무작위로 등장하는 차량을 피하고  
제한 시간 동안 목적지까지 배송을 진행하는 미니게임입니다.

- 차량 랜덤 생성
- 플레이어 차량 이동
- 차량 간 충돌 판정
- HP 시스템
- 제한 시간 및 게임 진행 UI

<br>

## ✨ Key Features

| 기능 | 구현 내용 |
| --- | --- |
| 🗺️ **World** | 캐릭터 이동 및 건물 입장을 통한 게임 시작 |
| 📦 **Random Spawn** | 택배 및 차량 오브젝트 랜덤 생성 |
| 🎯 **Sorting System** | 택배 종류에 따른 성공 / 실패 판정 |
| 🔥 **Combo System** | 연속 성공에 따른 Combo 처리 |
| 💥 **Collision** | 차량 충돌 판정 및 HP 처리 |
| ⏱️ **Game UI** | Combo, HP, Timer 등 게임 상태 표시 |
| 🔄 **Scene Management** | 월드와 각 Stage 간 Scene 전환 |

<br>

## 🛠 Tech Stack

| Category | Technology |
| --- | --- |
| **Game Engine** | Unity |
| **Language** | C# |
| **IDE** | Visual Studio |
| **Version Control** | Git / GitHub |

<br>

## 📁 Project Structure

```text
Assets/
├── Scenes/          # 게임 Scene
├── Scripts/         # 게임 로직
├── Prefabs/         # 게임 오브젝트
└── ...

Packages/
ProjectSettings/
