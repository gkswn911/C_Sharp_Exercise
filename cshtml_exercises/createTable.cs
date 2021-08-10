// Get QueryString From URL.           
$(document).ready(function () {
  const urlParams = new URLSearchParams(location.search);

  getData(urlParams.get(params..));
});

// GetData From Procedure
function getData(leId, srId, gId) {
  var request = $.ajax({
      type: "post"
      , url: "/ws/..."
      , dataType: "json"
      , data: {
          param1: param1
          , param2: param2
          ,...
      }
      , async: false
      , error: function (e) {
          console.log(e);
      }
  });
  // Get return
  request.done(function (data) {
      createTable(data);
  });
}

function createTable(data) {

  // JSON -> List -> Array
  let dataKeys = Object.values(data);
  dataKeys = dataKeys[0];
  let keysLength = dataKeys.length;

  if (keysLength % 2 == 1) keysLength += 1;

  // Get Types
  function isA(element) {
      if (element.col = 'A') {
          return true;
      }
  }

  function isB(element) {
      if (element.col == 'B') {
          return true;
      }
  }
  const aS = dataKeys.filter(isA);
  const bS = dataKeys.filter(isB);
