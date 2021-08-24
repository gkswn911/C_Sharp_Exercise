### String[]을 String으로 Converting 하기

string weekdays = "월,화,수,목,금,토,일"; // ,로 연결된 문자열
string[] arrWeekdays = weekdays.Split(','); //배열로 만든다
string weekdays2 = String.Join(",", arrWeekdays); //배열을 다시 ,로 연결된 문자열로 만든다

### .aspx 파일에서 네임스페이스 정의하기

<%@ namespace="System.net.Mail" %>

### DataTable 복사, .Clone()과 .Copy의 비교

<p>DataTable.Clone()은 데이터테이블 스키마만 복사
DataTable.Copy()는 데이터테이블 스키마 및 데이터 복사</p>

### PreparedStatement 방식 쿼리에서 Null값을 넣을때 처리

param[0].Value = idx == null ? (object)DBNull.Value : idx;
myCommand.Parameters.Add("@myName", myName == null ? (object)DBNull.Value : myName);

### Debug.WriteLine을 이용한 값 출력

콘솔을 찍어 중간에 확인할 수 있다. Debug.WriteLine()을 활용해 비쥬얼 스튜디오의 Debug 창에 찍어 볼 수 있다. (Ctrl + Alt + O)

using System.Diagnostics; //Debug클래스의 네임스페이스 추가
 
public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Debug.WriteLine("디버그 창에 출력한다.");
    }
}





