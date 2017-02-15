$(function(){
  $(".rock").click(function(){
    $(".paper").removeClass("highlight-box");
    $(".scissors").removeClass("highlight-box");
    $(".rock").addClass("highlight-box");
  });

  $(".paper").click(function(){
    $(".rock").removeClass("highlight-box");
    $(".scissors").removeClass("highlight-box");
    $(".paper").addClass("highlight-box");
  });

  $(".scissors").click(function(){
    $(".paper").removeClass("highlight-box");
    $(".rock").removeClass("highlight-box");
    $(".scissors").addClass("highlight-box");
  });
});
