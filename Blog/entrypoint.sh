#!/bin/bash

echo "⏳ منتظر SQL Server هستیم..."

# چک می‌کنه که آیا پورت 1433 روی کانتینر sqlserver باز شده یا نه
until nc -z sqlserver 1433; do
  echo "🕐 SQL Server هنوز آماده نیست. منتظریم..."
  sleep 1
done

echo "✅ SQL Server آماده‌ست! حالا برنامه رو اجرا می‌کنیم..."
dotnet Blog.dll
