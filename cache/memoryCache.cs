// 프로시저 실행 결과값을 MemoryCache에 저장. 
// 게시판에는 Cache의 값만 출력한다.
public JObject GetCache(int bdNo, int bdNum)
        {
            // return할 result 변수 생성.
            JObject result = new JObject();
            try
            {
                // CacheBoard 출력
                ObjectCache cache = MemoryCache.Default;
                
                // 동적으로 변하는 파라미터 값을 담기위한 Key문자열 선언.
                string key;
                                
                key = string.Format("PROC_BOARD_S_{0}_{1}", bdNo, bdNum);
              
                // 1이면 새로운 게시글이 업데이트 or 수정 or 삭제된 것
                if (flag == 1)
                {
                    // flag값에 따른 캐시값 삭제.
                    cache.Remove(key);
                    flag = 0;
                }
                
                // DataSet형의 caData변수에 Return 값 전달. 
                // null이라면 캐시가 존재 X.
                DataSet caData = cache[key] as DataSet;

                // null 이면 Cache
                if (caData == null)
                {
                    // DB의 Procedure에 접근하는 Code 생략.
                  
                    // key에 대한 캐시값이 존재한다면 Update시켜주고
                    // 없다면 새롭게 Insert한다.
                    cache.Set(key, caData, new CacheItemPolicy()
                    {   
                        // 우선순위로 제거할 캐시 설정.
                        Priority = CacheItemPriority.Default
                        // AbsoluteExpiration의 반대다. 만료시간 중간에 이벤트가 발생하면
                        // 갱신된다.
                        , SlidingExpiration = TimeSpan.FromSeconds(60)
                    });
                }

                // Procedure 반환 값을 List에 담아주는 Code 생략.              
                result.Add(new JProperty("code", "100"));
                result.Add(new JProperty("list", list));
            }
            // 예외처리. 예외 발생 시 code 200을 날린다.
            catch (Exception ex)
            {
                result.Add(new JProperty("code", "200"));
            }
            return result;
        }
