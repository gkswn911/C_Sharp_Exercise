-- �Ķ���� ���� �޾� ���̺� Update �ϴ� ���ν���

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

	-- ��Ʈ��ũ Traffic�� ���̱� ���� ����
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Ʈ����� ����
		BEGIN TRAN;
			SAVE TRAN SV_PNT

				INSERT INTO BOARD_TABLE (Params..)
				VALUES
				(@PARAMS...)

		-- Ʈ����� �Ϸ�
		COMMIT TRAN;
	
	END TRY
	-- ����ó�� ����
	BEGIN CATCH
		SELECT
			'���⼭ ���� �߻�'
			,ERROR_NUMBER() AS ErrorNumber                   -- ���� ��ȣ�� ��ȯ
			,ERROR_SEVERITY() AS ErrorSeverity               -- �ɰ����� ��ȯ
			,ERROR_STATE() AS ErrorState                     -- ���� ���� ��ȣ�� ��ȯ
			,ERROR_PROCEDURE() AS ErrorProcedure             -- ������ �߻��� ���� ���ν��� �Ǵ� Ʈ������ �̸��� ��ȯ
			,ERROR_LINE() AS ErrorLine                       -- ������ �߻���Ų ��ƾ ���� �� ��ȣ�� ��ȯ
			,ERROR_MESSAGE() AS ErrorMessage;                -- ���� �޽����� ���� �ؽ�Ʈ�� ��ȯ
		-- Ʈ����� ROLLBACK
		ROLLBACK TRAN;
	END CATCH
	SET NOCOUNT OFF
END;

--sp_helptext PROC_NAME_INSERT

--EXEC [PROC_NAME_INSERT] Params..