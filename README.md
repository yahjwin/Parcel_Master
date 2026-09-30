# Parcel Master

> 택배 회사의 업무를 택배 분류와 배송 미니게임으로 구현한 Unity 2D 캐주얼 게임

---

## Project Overview

**Parcel Master(택배 마스터)**는 Unity와 C#으로 개발한 2D 미니게임형 캐주얼 게임입니다.

플레이어는 월드를 이동하며 택배 회사 건물에 입장하고, **택배 분류 → 배송**으로 이어지는 두 단계의 미니게임을 진행합니다.

첫 번째 단계에서는 무작위로 등장하는 택배를 종류에 맞게 분류하고, 두 번째 단계에서는 택배 차량을 조작하여 도로에서 등장하는 차량을 피하며 제한 시간 동안 주행합니다.

**월드 이동 → 건물 입장 → 택배 분류 → 차량 주행**으로 이어지는 게임 플레이 흐름을 구성하고, 각 단계에 필요한 랜덤 오브젝트 생성, 판정, 충돌 및 게임 상태 관리 기능을 구현했습니다.

---


## 🎬 Demo Play

[![Parcel Master Demo](https://img.youtube.com/vi/wRStJXdz-yI/0.jpg)](https://youtu.be/wRStJXdz-yI)

> 이미지를 클릭하면 전체 플레이 영상을 확인할 수 있습니다.

## Project Information

| Category        | Description           |
| --------------- | --------------------- |
| Development     | Individual Project    |
| Genre           | 2D Casual / Mini Game |
| Engine          | Unity                 |
| Language        | C#                    |
| Platform        | PC                    |
| Version Control | Git / GitHub          |

---

## Gameplay

### Parcel Sorting

택배 회사에 입장하면 시작되는 첫 번째 미니게임입니다.

위에서 무작위로 등장하는 택배를 확인하고 종류에 맞게 분류합니다. 올바르게 분류하면 성공으로 처리되며, 연속 성공에 따라 Combo가 증가합니다.

**주요 기능**
- 택배 오브젝트 랜덤 생성
- 택배 종류별 분류 판정
- 성공 / 실패 처리
- Combo 시스템
- 게임 진행 상태 UI

---

### Delivery

택배 분류를 완료한 후 진행되는 두 번째 미니게임입니다.

플레이어가 택배 차량을 조작하여 도로에서 무작위로 등장하는 차량을 피하며 제한 시간 동안 주행합니다.

**주요 기능**
- 차량 랜덤 생성
- 플레이어 차량 이동
- 차량 간 충돌 판정
- HP 시스템
- 제한 시간 관리
- 게임 진행 상태 UI

---

## Key Features

### Random Object Spawn

택배 분류 단계에서는 다양한 택배가 무작위로 등장하고, 배송 단계에서는 도로 위 차량이 무작위로 생성되도록 구현했습니다.

### Parcel Sorting System

택배의 종류와 플레이어가 선택한 분류 위치를 비교하여 성공과 실패를 판정하고, 연속 성공 결과를 Combo에 반영하도록 구현했습니다.

### Vehicle Collision System

플레이어 차량과 다른 차량의 충돌을 감지하고, 충돌 결과가 HP에 반영되도록 구성했습니다.

### Game State UI

각 미니게임의 진행 상황을 확인할 수 있도록 Combo, HP, Timer 등의 게임 상태를 UI로 표시했습니다.

### Scene Progress

메인 월드와 각 미니게임을 개별 Scene으로 구성하고, 게임 진행 순서에 따라 다음 단계로 이동하도록 구현했습니다.

---

## Source Code

게임 진행과 각 미니게임에 필요한 로직을 C#으로 구현했습니다.

`Assets/Scripts/`

> 주요 스크립트 및 디렉터리 구조는 실제 프로젝트 구조에 맞춰 추가 예정

---

## Tech Stack

| Category        | Technology |
| --------------- | ---------- |
| Game Engine     | Unity      |
| Language        | C#         |
| UI              | Unity UI   |
| Version Control | Git, GitHub |

---

## Development Highlights

**Randomized Gameplay**  
택배와 차량의 등장에 랜덤 요소를 적용하여 반복 플레이에서도 오브젝트의 등장 패턴이 달라지도록 구성했습니다.

**Two Different Mini-game Systems**  
택배를 종류에 따라 분류하는 판정형 게임과 차량을 조작해 장애물을 피하는 회피형 게임을 하나의 게임 흐름으로 연결했습니다.

**Collision & Game State Management**  
차량 충돌에 따른 HP 변화와 제한 시간 등 플레이 상태를 관리하고 이를 UI에 반영했습니다.

**Scene-based Game Flow**  
메인 월드와 두 개의 미니게임을 Scene 단위로 구성하여 단계별 게임 진행 흐름을 구현했습니다.

---

## Gameplay Demo

https://youtu.be/wRStJXdz-yI

---

## Developer

**yahjwin**
