#!/bin/sh

echo "⏳ منتظر SQL Server هستیم..."

until nc -z sqlserver 1433; do
  echo "🕐 SQL Server هنوز آماده نیست. منتظریم..."
  sleep 1
done

echo "✅ SQL Server آماده‌ست! حالا برنامه رو اجرا می‌کنیم..."
dotnet Blog.dll
