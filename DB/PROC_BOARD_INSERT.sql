-- 파라미터 값을 받아 테이블에 Update 하는 프로시저

-- Input Parameters 
CREATE PROCEDURE PROC_NAME_INSERT (
	@PARAMS1 VARCHAR(15)
	, @PARAMS2 VARCHAR(128)
	, @PARAMS3 VARCHAR(128)
	, @PARAMS4 NVARCHAR(100)
	, @PARAMS15 NTEXT
)

AS
BEGIN
	
	-- Set Variable
	DECLARE @VAR1 INT
	, @VAR2 INT
	-- Get Value Logic
	SELECT  @VAR1 = (@VAR1 + 100)
			FROM
			(
				SELECT TOP 1 @VAR1
				FROM BOARD_TABLE
			) AS A

	-- 네트워크 Traffic을 줄이기 위해 설정
	SET NOCOUNT ON
	BEGIN TRY
		
		-- 트랜잭션 시작
		BEGIN TRAN;
			SAVE TRAN SV_PNT

				INSERT INTO BOARD_TABLE (Params..)
				VALUES
				(@PARAMS...)

		-- 트랜잭션 완료
		COMMIT TRAN;
	
	END TRY
	-- 예외처리 진입
	BEGIN CATCH
		SELECT
			'여기서 에러 발생'
			,ERROR_NUMBER() AS ErrorNumber                   -- 오류 번호를 반환
			,ERROR_SEVERITY() AS ErrorSeverity               -- 심각도를 반환
			,ERROR_STATE() AS ErrorState                     -- 오류 상태 번호를 반환
			,ERROR_PROCEDURE() AS ErrorProcedure             -- 오류가 발생한 저장 프로시저 또는 트리거의 이름을 반환
			,ERROR_LINE() AS ErrorLine                       -- 오류를 발생시킨 루틴 내의 줄 번호를 반환
			,ERROR_MESSAGE() AS ErrorMessage;                -- 오류 메시지의 전테 텍스트를 반환
		-- 트랜잭션 ROLLBACK
		ROLLBACK TRAN;
	END CATCH
	SET NOCOUNT OFF
END;

--sp_helptext PROC_NAME_INSERT

--EXEC [PROC_NAME_INSERT] Params..