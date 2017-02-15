$(function(){
  $(".player2div").hide();
  $("#next-player").click(function(){
    $(".player1div").hide();
    $(".player2div").show();
  });
});
