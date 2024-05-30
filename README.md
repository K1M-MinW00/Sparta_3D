# 🐰 Find the Carrots
 아빠 토끼가 되어 아기 토끼들을 위해 숨겨진 당근을 찾아라

<br>

## 📂 프로젝트 소개
캐릭터 이동과 물리 처리를 구현한 1인칭 시점의 Unity 3D 프로젝트입니다.

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

### 해와 달
시간이 흐름에 따라, 해와 달이 번갈아가며 뜹니다.
밤이 되면, 시야가 제한됩니다.

<br>

## 🎬 플레이 화면

### 1. Intro Scene
게임 시작 전 화면 입니다.
<details>
  <summary> ▶ 시작 화면</summary>
  <img src = "https://github.com/K1M-MinW00/Sparta_3D/assets/122630746/3ed8baeb-439d-466a-bdef-53c029f95e4f" width = 500>
</details>

<br>

### 2. Main Scene
- 본격적인 게임 화면 입니다.
- 아빠 토끼가 되어, 아기 토끼들을 위해 7개의 당근을 찾아야 합니다. 맵에는 10개의 당근이 존재합니다.
- ⌨ W/A/S/D 키를 통해 캐릭터를 움직이고, 🖱 마우스를 통해 시야를 움직일 수 있습니다.
- Ray 를 통해, 바라보는 곳에 아이템이 있으면 아이템 정보를 알려줍니다.
- 🥕 E 키를 눌러 아이템을 줍고, 👜 Tab 키를 눌러 인벤토리를 열 수 있습니다. 
- 체력과 배고픔 시스템이 존재합니다. 배고픔이 0 이 되면, 체력이 감소하니 주의하세요.
- 🍄 버섯 아이템을 통해 높게 점프할 수 있습니다.

<details>
  <summary> 🎮 플레이어 이동 / 📃 아이템 정보 </summary>
  <img src = "https://github.com/K1M-MinW00/Sparta_3D/assets/122630746/b1dc3eeb-5119-4c01-9160-10f2a365d5a3" width = 500>
</details>

<details>
  <summary> 🎁 아이템 사용 </summary>
  <img src = "https://github.com/K1M-MinW00/Sparta_3D/assets/122630746/89c15779-36b3-4b62-9bad-272ba428d92e" width = 500>
</details>

<details>
  <summary> 🌞 해와 달 🌚</summary>
  <img src = "https://github.com/K1M-MinW00/Sparta_3D/assets/122630746/67e881a6-b6ad-4c1e-ae7c-7c10dd0c94c5" width = 500>
</details>

<details>
  <summary> ☕ 버프 아이템 / 🍄 점프대 </summary>
  <img src = "https://github.com/K1M-MinW00/Sparta_3D/assets/122630746/41254f2a-c974-401e-8053-2e343baf45c0" width = 500>
</details>

<br>

### 3. GameOver Scene
- 당근을 다 모으기 전, 체력이 0 이 되면 등장하는 장면입니다.
- **다시하기 와 종료하기**, 2 가지 버튼이 있습니다.
  
<details>
  <summary> 😢 게임 오버 </summary>
  <img src = "https://github.com/K1M-MinW00/Sparta_3D/assets/122630746/a64cca45-c0f2-4e93-9943-38b3e474ff5a" width = 500>
</details>

<br>

### 4. End Scene
- 당근을 다 모아, 게임을 클리어했을 때 등장하는 장면입니다.
- **다시하기 와 종료하기**, 2 가지 버튼이 있습니다.

<details>
  <summary> 😆 게임 클리어  </summary>
  <img src = "https://github.com/K1M-MinW00/Sparta_3D/assets/122630746/edba346f-c9c6-477c-848c-94e319379e4b" width = 500>
</details>

<br>

## 사용 에셋

디자인 에셋 [RPG Poly Pack - Lite](https://assetstore.unity.com/packages/3d/environments/landscapes/rpg-poly-pack-lite-148410) , [Simple Low Poly Nature Pack](https://assetstore.unity.com/packages/3d/environments/landscapes/simple-low-poly-nature-pack-157552) , [Low Poly Food Lite](https://assetstore.unity.com/packages/3d/props/food/low-poly-food-lite-258693)

캐릭터 (토끼) 에셋 [White Rabbit](https://assetstore.unity.com/packages/3d/characters/animals/white-rabbit-138709)

[아이콘](https://game-icons.net/)
  

