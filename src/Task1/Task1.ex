defmodule Divisibility do
  def check_numbers do
    for n <- 1..100, do: check_divisibility(n)
  end

  defp check_divisibility(n) do
    cond do
      rem(n, 3) == 0 and rem(n, 5) == 0 -> "Div3&5"
      rem(n, 3) == 0 -> "Div3"
      rem(n, 5) == 0 -> "Div5"
      true -> n
    end
  end
end

# Testing the program
IO.inspect(Divisibility.check_numbers())
