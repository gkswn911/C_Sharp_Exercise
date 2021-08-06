/*
프로시저에 파라미터 값을 넘겨서 값을 출력.

*/

CREATE PROC [프로시저 명] (
[@변수명]  [데이터 타입]
...
)

AS
BEGIN
  -- 네트워크 이동량이 줄어 성능 향상 
  SET NOCOUNT ON
  
  BEGIN TRY
    DECLARE [@변수명] [데이터타입]
    
    SET [선언된 변수] = [파라미터] 
    
    ```
    [실행할 SQL문 작성]
    ```
        
  END TRY
  BEGIN CATCH
    SELECT 
        '여기서 에러 발생'
        ,ERROR_NUMBER() AS ErrorNumber                   -- 오류 번호를 반환
        ,ERROR_SEVERITY() AS ErrorSeverity               -- 심각도를 반환
        ,ERROR_STATE() AS ErrorState                     -- 오류 상태 번호를 반환
        ,ERROR_PROCEDURE() AS ErrorProcedure             -- 오류가 발생한 저장 프로시저 또는 트리거의 이름을 반환
        ,ERROR_LINE() AS ErrorLine                       -- 오류를 발생시킨 루틴 내의 줄 번호를 반환
        ,ERROR_MESSAGE() AS ErrorMessage;                -- 오류 메시지의 전테 텍스트를 반환
  END CATCH
END
  
  
-- Search for Procedure
-- sp_helptext [프로시저 명] 

-- Execute for Procedure
-- exec [프로시저 명] [파라미터 1], [파라미터 2], ...
