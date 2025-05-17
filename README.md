# ASP.NET Core Web API 샘플 프로젝트

이 프로젝트는 Claude를 통해 생성된 ASP.NET Core Web API 샘플 프로젝트입니다.

## 기술 스택

- ASP.NET Core 8.0
- Entity Framework Core
- MS SQL Server
- C#
- Swagger

## 프로젝트 구조

- `Controllers/`: API 컨트롤러
- `Models/`: 데이터 모델
- `Data/`: 데이터베이스 컨텍스트 및 관련 클래스
- `Services/`: 비즈니스 로직 서비스

## 시작하기

### 필수 조건

- .NET 8.0 SDK
- MS SQL Server

### 설치 및 실행

1. 저장소를 클론합니다.
2. `appsettings.json`에서 데이터베이스 연결 문자열을 설정합니다.
3. 다음 명령어로 데이터베이스를 마이그레이션합니다:
   ```
   dotnet ef database update
   ```
4. 프로젝트를 실행합니다:
   ```
   dotnet run
   ```
5. 브라우저에서 `https://localhost:5001/swagger`로 접속하여 API를 테스트합니다.

## API 엔드포인트

- `GET /api/products`: 모든 제품 목록을 가져옵니다.
- `GET /api/products/{id}`: 특정 ID의 제품을 가져옵니다.
- `POST /api/products`: 새 제품을 추가합니다.
- `PUT /api/products/{id}`: 특정 ID의 제품을 업데이트합니다.
- `DELETE /api/products/{id}`: 특정 ID의 제품을 삭제합니다.

## 보안

이 프로젝트는 샘플이므로 실제 프로덕션 환경에서 사용하기 전에 보안 설정을 추가해야 합니다.

## 라이선스

MIT