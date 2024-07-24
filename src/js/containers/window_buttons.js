jQuery("#windowButton_reduce").on("click", (event) => {
  window.windowAPI.windowReduce();
});

jQuery("#windowButton_exit").on("click", (event) => {
  window.windowAPI.windowClose();
});
