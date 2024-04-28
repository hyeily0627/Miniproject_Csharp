# Miniproject_Csharp
C# 미니프로젝트 (MiniProject_3_최종폴더)

* 코딩기간 : 2024-04-25 ~ 2024-04-26
* 프로젝트 : 제이버(Javer) 로그인 화면폼 - 네이버 Copy 

---------------------------------------------------------------

## FrmMain.cs 
![FrmMain](https://github.com/hyeily0627/Miniproject_Csharp/assets/156732476/9fc73cc4-dbee-43a8-8299-640cbb0e6378)

- 로그인 첫 이미지 
    - (🚨구현) 버튼 정상 연결
    - 로그인버튼 오류는 잡히질 않아요,,,ヾ(￣▽￣) 

## FrmLogin.cs
![FrmLogin](https://github.com/hyeily0627/Miniproject_Csharp/assets/156732476/62865e69-c525-4874-a6d5-060cb94debff)

- 아이디, 패스워드를 입력할 수 있는 로그인 페이지 
    - (🚨구현) 아이디 비번 잘못 입력시에는 경고창, 정상입력시에는 원래 페이지로 복귀
    - (🚨구현) 로그인 방법 3가지 화면 전환(ID 로그인, 일회용 번호, QR코드)
    - (❗❗미구현) QR코드 페이지 만들기
    - (❗❗미구현) 로그인 성공 후 생성되는 페이지 폼 만들기

## FrmFindPassword.cs
![FrmFindPassword](https://github.com/hyeily0627/Miniproject_Csharp/assets/156732476/69107f34-d854-4d52-b2a8-186926d3e1bb)

- 비밀번호 찾기 페이지 
    - (❗❗미구현) DB에서 아이디로 찾을 수 있도록?

## FrmFindId.cs
![FrmFindId](https://github.com/hyeily0627/Miniproject_Csharp/assets/156732476/22383f11-21bc-41dd-a8f0-b65ed0d8ceff)

- 아이디 찾기 페이지 
    - (❗❗미구현) DB에서 선택값이었던 이메일, 전화번호 등을 회원가입때 입력했다면 매핑해서 찾을 수 있도록?

## FrmRegister.cs
![FrmRegister](https://github.com/hyeily0627/Miniproject_Csharp/assets/156732476/582da96b-e566-4595-8805-fdf54a05ef52)

- 회원가입 전 이용약관 동의 페이지 
    - (🚨구현) 콤보 박스(필수 항목) 미체크시 다음으로 못넘어가도록 설정
        ![필수](https://github.com/hyeily0627/Miniproject_Csharp/assets/156732476/0815d377-0dbc-49c7-a097-1191ac8a4fb5)

    - (🚨구현) 텍스트 박스 길어질 시 스크롤 되는 텍스트 박스로 변경
    - (❗❗미구현) 언어선택 시 중국어 일본어 러시아어 자체가 안뜨는 현상(유니코드?)
        ![언어설정](https://github.com/hyeily0627/Miniproject_Csharp/assets/156732476/346390c5-556d-4939-84ba-a5f68b16aa18)

        - 개발 할 시간이 있다면 영어 정도는 선택시 바뀔 수 있게 작성해보기~! 

## FrmRegInfo.cs
![FrmRegInfo](https://github.com/hyeily0627/Miniproject_Csharp/assets/156732476/dd56abe1-fb34-4483-befb-f00f03c00c6a)

- 회원가입 정보입력 페이지(실질적 DB저장)
    - (🚨구현) 신규버튼 -> 필수값 입력 -> 저장 시 DB 저장 
    - (❗❗미구현) 아이디 비번을 제외한 항목들 DB연동 안시킴 
    - (❗❗미구현) 항목마다 맞는 아이콘 삽입하기 

---------------------------------------------------------------------

## 배운점 및 개선점 
- text박스가 아닌 Label 사용해야 커서 이동이 없어 드래그 되는 현상 발생안함 
