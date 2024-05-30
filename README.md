# 🐰 Find the Carrots
 아빠 토끼가 되어 아기 토끼들을 위해 숨겨진 당근을 찾아라

<br>

## 📂 프로젝트 소개
Unity3D의 캐릭터 이동과 물리 처리를 구현한 1인칭 3D 프로젝트입니다.

<br>

### 📆 제작 기간
**24-05-22 ~ 24-05-30**

### 👨‍💻 제작 인원
**김민우**

<br>

## 📌 주요 기능

### Input System 을 통한 Player 움직임 구현
W/A/S/D 키를 통해 캐릭터를 이동,
Space Bar 키를 통해 점프,
Tab 키를 통해 인벤토리,
E 키를 통해 아이템과 상호작용,
마우스 위치를 통해 캐릭터의 시선을 바뀌게 설정하였습니다.

### RayCast 를 통한 물체 감지
캐릭터의 시야 방향으로 Ray 를 발사하여 물체를 감지합니다.
조사한 물체의 이름과 설명은 UI 를 통해 나타냅니다.

### 아이템 및 인벤토리
맵 곳곳에 여러 아이템이 드랍되어 있습니다.
아이템과 상호 작용하여 인벤토리에 넣을 수 있고,
인벤토리에 있는 아이템을 사용하거나 버릴 수 있습니다.

### 아이템 효과
특정 아이템은 버프 효과를 줍니다.
일시적으로 이동 속도가 빨라지거나, 점프 거리가 증가했다가 감소합니다.

### 점프대
캐릭터가 버섯(점프대) 에 닿았을 때, onCollisionEnter 트리거와 ForceMode.Impulse 를 사용해 하늘을 향해 순간적인 힘을 가해줍니다.

<br>

## 🎬 플레이 화면

### 1. Intro Scene
- 가장 먼저 보여지는 화면입니다.
- **게임 시작 , 사운드 조절 , 나가기**, 3 가지 버튼이 있습니다.

<details>
  <summary> 🎬 인트로 / 🔊 사운드 설정</summary>
  <img src = "https://github.com/SnowScapes/DefendTheCastle/assets/122630746/f5706958-6cf5-4f22-8a4a-548b0eb3c4e2" width = 500>
</details>

<br>

### 2. Tutorial Scene
- 기초 가이드를 제공하는 화면입니다.
- **적들에 대한 정보, 게임 종료 조건, 아이템**에 대한 정보를 제공합니다.

<details>
  <summary> 📕 튜토리얼</summary>
  <img src = "https://github.com/SnowScapes/DefendTheCastle/assets/122630746/0666a15a-a10e-4055-b049-57d3ab068896" width = 500>
</details>

<br>

### 3. Main Scene
- 본격적인 게임 화면 입니다.
- ⌨ W/A/S/D 키를 통해 캐릭터를 움직이고, 🖱 마우스 좌클릭을 통해 공격합니다.
- 적을 처치하면 다양한 아이템이 드랍됩니다.
- 상점을 통해 업그레이드를 진행할 수 있습니다.
- 특수 기능을 통해, 쿨 타임마다 성을 수리할 수 있습니다.
<details>
  <summary> 🎮 플레이어 이동 / 💎 상점 </summary>
  <img src = "https://github.com/SnowScapes/DefendTheCastle/assets/122630746/bb5403d4-b9f2-4148-a5cc-7dbd7bf5020c" width = 500>
</details>

<details>
  <summary> 🏹 공격 / 🧟‍♂️ 적 / 🎁 아이템 </summary>
  <img src = "https://github.com/SnowScapes/DefendTheCastle/assets/122630746/44b6d181-279c-467e-bba1-a9c870886c59" width = 500>
</details>

<details>
  <summary> 🛠 특수 기능 </summary>
  <img src = "https://github.com/SnowScapes/DefendTheCastle/assets/122630746/48df322c-6a44-4617-83de-a662180585bf" width = 500>
</details>

<br>

### 4. End Scene
- 게임 성공 또는 실패 시 이동하게 되는 화면입니다.
- **다시하기 와 종료하기**, 2 가지 버튼이 있습니다.
- 점수 로직을 통해 계산한 점수를 표시해줍니다.

<details>
  <summary> 🖼 엔딩 씬/ 📊 점수 표시  </summary>
  <img src = "https://github.com/SnowScapes/DefendTheCastle/assets/122630746/23ffcb75-2977-4525-80c4-632e6c65695b" width = 500>
  <img src ="https://github.com/SnowScapes/DefendTheCastle/assets/122630746/ff3f3317-5296-40b7-a97b-84849023d77f" width = 500>
</details>

<br>

## 사용 에셋

디자인 에셋 [RPG Poly Pack - Lite](https://assetstore.unity.com/packages/3d/environments/landscapes/rpg-poly-pack-lite-148410) , [Simple Low Poly Nature Pack](https://assetstore.unity.com/packages/3d/environments/landscapes/simple-low-poly-nature-pack-157552) , [Low Poly Food Lite](https://assetstore.unity.com/packages/3d/props/food/low-poly-food-lite-258693)

캐릭터 (토끼) 에셋 [White Rabbit](https://assetstore.unity.com/packages/3d/characters/animals/white-rabbit-138709)

[아이콘](https://game-icons.net/)
  

